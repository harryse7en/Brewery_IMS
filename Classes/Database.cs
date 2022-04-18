using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Brewery_IMS.Classes {
    public class Database {

        // ---------- Variables ----------
        public string DbName, Password, Port, Server, Uid;
        public bool IsConnected { get; set; }



        // ---------- Constructor ----------
        public Database() {
            IsConnected = false;
        }



        // ---------- Functions ----------
        public MySqlConnection Connect() {
            string connStr = string.Format("Server={0}; Port={1}; Database={2}; Uid={3}; Password={4}", Server, Port, DbName, Uid, Password);
            MySqlConnection connection = new MySqlConnection(connStr);

            try {
                connection.Open();
                IsConnected = true;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Cannot connect to MySql database:  " + ex, "ERROR");
                IsConnected = false;
            }
            return connection;
        }
        public int checkLogin(string uid, string pwd) {  // Function to check the login credentials
            int _userId;
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        // Check to ensure the username and password provided match the database table
                        cmd.CommandText = "SELECT userId FROM users WHERE userName = @uid AND userPass = @pwd";
                        cmd.Parameters.AddWithValue("@uid", uid);
                        cmd.Parameters.AddWithValue("@pwd", pwd);
                        if (cmd.ExecuteScalar() != null) {   // Login success
                            _userId = (int)cmd.ExecuteScalar();
                            return _userId;
                        } else {   // Login failure
                            MessageBox.Show("Invalid username or password");
                            return -1;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while checking login credentials:  " + ex, "ERROR");
                        return -2;
                    }
                } else {
                    return -2;
                }
            }
        }
        public int getAutoIncrement(string tblName) { // Function to select the auto_increment value while creating new records
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        // Check to see if an item record already exists for this recipe
                        cmd.CommandText = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_NAME = @tblName";
                        cmd.Parameters.AddWithValue("@tblName", tblName);
                        if (cmd.ExecuteScalar() != null) {
                            return Int32.Parse(cmd.ExecuteScalar().ToString());
                        } else {
                            return 0;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while getting the auto_increment value:  " + ex, "ERROR");
                        return 0;
                    }
                } else {
                    return 0;
                }
            }
        }

        // Batches
        public bool abortBatch(int id) { // Function to abort a batch's sequence
            DataTable dt = getBatch(id);
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE batch SET sequence = @sequence, endDate = @endDate, lastUpdateBy = @lastUpdateBy," +
                            " lastUpdate = CURRENT_TIMESTAMP() WHERE batchId = @id";
                        cmd.Parameters.AddWithValue("@sequence", 7);
                        cmd.Parameters.AddWithValue("@endDate", System.DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while aborting the batch sequence:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool advanceBatch(int id) { // Function to advance a batch's sequence
            DataTable dt = getBatch(id);
            int seq = (int)dt.Rows[0]["sequence"];
            int nextSeq = seq;
            nextSeq = (seq < 7) ? seq + 1 : seq;
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE batch SET sequence = @sequence WHERE batchId = @id";
                        cmd.Parameters.AddWithValue("@sequence", nextSeq);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while advancing the batch sequence:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool createBatch(Batch batch) { // Function to create and start a batch
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO batch(name, description, sequence, startDate, endDate, recipeId, lastUpdateBy, lastUpdate)" +
                            " VALUES(@name, @description, @sequence, @startDate, @endDate, @recipeId, @lastUpdateBy, CURRENT_TIMESTAMP())";
                        cmd.Parameters.AddWithValue("@name", batch.Name);
                        cmd.Parameters.AddWithValue("@description", batch.Description);
                        cmd.Parameters.AddWithValue("@sequence", batch.Sequence);
                        cmd.Parameters.AddWithValue("@startDate", batch.StartDate);
                        cmd.Parameters.AddWithValue("@endDate", batch.EndDate);
                        cmd.Parameters.AddWithValue("@recipeId", batch.RecipeID);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while creating the new batch:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool deleteBatch(int id) { // Function to delete a batch
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM batch WHERE batchId = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while deleting the batch:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public DataTable getAllBatches() { // Function to get all batches
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT batchId, batch.name, batch.description, batch.sequence, batch_seq.text AS sequenceText," +
                        " startDate, endDate, batch.recipeId, recipes.name as recipeName FROM batch INNER JOIN recipes ON batch.recipeId = recipes.recipeId" +
                        " INNER JOIN batch_seq ON batch.sequence = batch_seq.sequence";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting all batches:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable getBatch(int id) { // Function to get all batches
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT batchId, batch.name, batch.description, batch.sequence, batch_seq.text AS sequenceText," +
                        " startDate, endDate, batch.recipeId, recipes.name as recipeName FROM batch INNER JOIN recipes ON batch.recipeId = recipes.recipeId" +
                        " INNER JOIN batch_seq ON batch.sequence = batch_seq.sequence WHERE batchId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting the batch:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public bool startBatch(int id, int recipeId) { // Function to start a batch's sequence
            int days;
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT days FROM recipes WHERE recipeId = @id";
                        cmd.Parameters.AddWithValue("@id", recipeId);
                        if (cmd.ExecuteScalar() != null) {
                            days = (int)cmd.ExecuteScalar();
                        } else {
                            days = 10;
                        }
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE batch SET sequence = @sequence, startDate = CURRENT_DATE(), endDate = DATE_ADD(CURRENT_DATE(), INTERVAL @days DAY), lastUpdateBy = @lastUpdateBy, lastUpdate = CURRENT_TIMESTAMP() WHERE batchId = @id";
                        cmd.Parameters.AddWithValue("@sequence", 2);
                        cmd.Parameters.AddWithValue("@days", days);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while starting the batch:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool updateBatch(Batch batch) { // Function to update a batch
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE batch SET name = @name, description = @description, sequence = @sequence," +
                            " startDate = @startDate, endDate = @endDate, recipeId = @recipeId, lastUpdateBy = @lastUpdateBy," +
                            " lastUpdate = CURRENT_TIMESTAMP() WHERE batchId = @id";
                        cmd.Parameters.AddWithValue("@name", batch.Name);
                        cmd.Parameters.AddWithValue("@description", batch.Description);
                        cmd.Parameters.AddWithValue("@sequence", batch.Sequence);
                        cmd.Parameters.AddWithValue("@startDate", batch.StartDate);
                        cmd.Parameters.AddWithValue("@endDate", batch.EndDate);
                        cmd.Parameters.AddWithValue("@recipeId", batch.RecipeID);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", batch.ID);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while updating the batch:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }

        // Equipment
        public bool createEquipment(Equipment eqpt) { // Function to create equipment
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO equipment(name, type, manufacturer, description, status, lastUpdateBy, lastUpdate)" +
                            " VALUES(@name, @type, @manufacturer, @description, @status, @lastUpdateBy, CURRENT_TIMESTAMP())";
                        cmd.Parameters.AddWithValue("@name", eqpt.Name);
                        cmd.Parameters.AddWithValue("@type", eqpt.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", eqpt.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", eqpt.Description);
                        cmd.Parameters.AddWithValue("@status", eqpt.Status);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while adding the new equipment:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool deleteEquipment(int id) { // Function to delete equipment
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM equipment WHERE equipmentId = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while deleting the equipment:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public DataTable getAllEquipment() { // Function to get all equipment
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT *, CASE WHEN status = 0 THEN 'Available' ELSE 'In Use' END AS statusText FROM equipment";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting all equipment:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable getEquipment(int id) { // Function to get all equipment
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT *, CASE WHEN status = 0 THEN 'Available' ELSE 'In Use' END AS statusText FROM equipment WHERE equipmentId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting the equipment:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public bool updateEquipment(Equipment eqpt) { // Function to update equipment
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE equipment SET name = @name, type = @type, manufacturer = @manufacturer, description = @description," +
                            " status = @status, lastUpdateBy = @lastUpdateBy, lastUpdate = CURRENT_TIMESTAMP() WHERE equipmentId = @id";
                        cmd.Parameters.AddWithValue("@name", eqpt.Name);
                        cmd.Parameters.AddWithValue("@type", eqpt.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", eqpt.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", eqpt.Description);
                        cmd.Parameters.AddWithValue("@status", eqpt.Status);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", eqpt.ID);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while updating the equipment:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }

        // Ingredients
        public bool createIngredient(IngrGrain grain) { // Overloaded function to create grain ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO ingredients(name, category, stock, type, manufacturer, description, color, unit, lastUpdateBy, lastUpdate)" +
                            " VALUES(@name, @category, @stock, @type, @manufacturer, @description, @color, @unit, @lastUpdateBy, CURRENT_TIMESTAMP())";
                        cmd.Parameters.AddWithValue("@name", grain.Name);
                        cmd.Parameters.AddWithValue("@category", "Grain");
                        cmd.Parameters.AddWithValue("@stock", grain.Stock);
                        cmd.Parameters.AddWithValue("@type", grain.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", grain.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", grain.Description);
                        cmd.Parameters.AddWithValue("@color", grain.Color);
                        cmd.Parameters.AddWithValue("@unit", grain.Unit);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("An error occurred while adding the new ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool createIngredient(IngrHop hop) { // Overloaded function to create hop ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO ingredients(name, category, stock, type, manufacturer, description, alpha, unit, lastUpdateBy, lastUpdate)" +
                            " VALUES(@name, @category, @stock, @type, @manufacturer, @description, @alpha, @unit, @lastUpdateBy, CURRENT_TIMESTAMP())";
                        cmd.Parameters.AddWithValue("@name", hop.Name);
                        cmd.Parameters.AddWithValue("@category", "Hop");
                        cmd.Parameters.AddWithValue("@stock", hop.Stock);
                        cmd.Parameters.AddWithValue("@type", hop.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", hop.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", hop.Description);
                        cmd.Parameters.AddWithValue("@alpha", hop.Alpha);
                        cmd.Parameters.AddWithValue("@unit", hop.Unit);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while adding the new ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool createIngredient(IngrYeast yeast) { // Overloaded function to create yeast ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO ingredients(name, category, stock, type, manufacturer, description, attenuation, unit, lastUpdateBy, lastUpdate)" +
                            " VALUES(@name, @category, @stock, @type, @manufacturer, @description, @attenuation, @unit, @lastUpdateBy, CURRENT_TIMESTAMP())";
                        cmd.Parameters.AddWithValue("@name", yeast.Name);
                        cmd.Parameters.AddWithValue("@category", "Yeast");
                        cmd.Parameters.AddWithValue("@stock", yeast.Stock);
                        cmd.Parameters.AddWithValue("@type", yeast.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", yeast.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", yeast.Description);
                        cmd.Parameters.AddWithValue("@attenuation", yeast.Attenuation);
                        cmd.Parameters.AddWithValue("@unit", yeast.Unit);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while adding the new ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool deleteIngredient(int id) { // Function to delete (any) ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM ingredients WHERE ingredientId = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "DELETE FROM recipeItems WHERE ingredientId = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while deleting the ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public DataTable getAllIngredients() { // Function to get all ingredients
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM ingredients";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting all ingredients:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable getIngredient(int id) { // Function to get all ingredients
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM ingredients WHERE ingredientId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting the ingredient:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public bool updateIngredient(IngrGrain grain) { // Overloaded function to update grain ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE ingredients SET name = @name, stock = @stock, type = @type, manufacturer = @manufacturer," +
                            " description = @description, color = @color, unit = @unit, lastUpdateBy = @lastUpdateBy, lastUpdate = CURRENT_TIMESTAMP()" +
                            " WHERE ingredientId = @id";
                        cmd.Parameters.AddWithValue("@name", grain.Name);
                        cmd.Parameters.AddWithValue("@stock", grain.Stock);
                        cmd.Parameters.AddWithValue("@type", grain.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", grain.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", grain.Description);
                        cmd.Parameters.AddWithValue("@color", grain.Color);
                        cmd.Parameters.AddWithValue("@unit", grain.Unit);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", grain.ID);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while updating the ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool updateIngredient(IngrHop hop) { // Overloaded function to update hop ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE ingredients SET name = @name, stock = @stock, type = @type, manufacturer = @manufacturer," +
                            " description = @description, alpha = @alpha, unit = @unit, lastUpdateBy = @lastUpdateBy, lastUpdate = CURRENT_TIMESTAMP()" +
                            " WHERE ingredientId = @id";
                        cmd.Parameters.AddWithValue("@name", hop.Name);
                        cmd.Parameters.AddWithValue("@stock", hop.Stock);
                        cmd.Parameters.AddWithValue("@type", hop.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", hop.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", hop.Description);
                        cmd.Parameters.AddWithValue("@alpha", hop.Alpha);
                        cmd.Parameters.AddWithValue("@unit", hop.Unit);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", hop.ID);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while updating the ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool updateIngredient(IngrYeast yeast) { // Overloaded function to update yeast ingredient
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE ingredients SET name = @name, stock = @stock, type = @type, manufacturer = @manufacturer," +
                            " description = @description, attenuation = @attenuation, unit = @unit, lastUpdateBy = @lastUpdateBy, lastUpdate = CURRENT_TIMESTAMP()" +
                            " WHERE ingredientId = @id";
                        cmd.Parameters.AddWithValue("@name", yeast.Name);
                        cmd.Parameters.AddWithValue("@stock", yeast.Stock);
                        cmd.Parameters.AddWithValue("@type", yeast.Type);
                        cmd.Parameters.AddWithValue("@manufacturer", yeast.Manufacturer);
                        cmd.Parameters.AddWithValue("@description", yeast.Description);
                        cmd.Parameters.AddWithValue("@attenuation", yeast.Attenuation);
                        cmd.Parameters.AddWithValue("@unit", yeast.Unit);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", yeast.ID);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while updating the ingredient:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }

        // Recipes
        public bool addRecipeItem(int recipeId, int ingrId, int qty) { // Function to add ingredients to recipe
            int _itemId, _itemQty;
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        // Check to see if an item record already exists for this recipe
                        cmd.CommandText = "SELECT itemId FROM recipeitems WHERE recipeId = @recipeId AND ingredientId = @ingredientId";
                        cmd.Parameters.AddWithValue("@recipeId", recipeId);
                        cmd.Parameters.AddWithValue("@ingredientId", ingrId);
                        if (cmd.ExecuteScalar() != null) {   // If the item already exists, change the qty
                            _itemId = (int)cmd.ExecuteScalar();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "SELECT itemQty FROM recipeitems WHERE itemId = @itemId";
                            cmd.Parameters.AddWithValue("@itemId", _itemId);
                            _itemQty = (int)cmd.ExecuteScalar();
                            _itemQty += qty;
                            cmd.Parameters.Clear();
                            cmd.CommandText = "UPDATE recipeitems SET itemQty = @itemQty WHERE itemId = @itemId";
                            cmd.Parameters.AddWithValue("@itemQty", _itemQty);
                            cmd.Parameters.AddWithValue("@itemId", _itemId);
                            cmd.ExecuteNonQuery();
                        } else {   // If the item doesn't exist, create a new record
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO recipeitems(recipeId, itemQty, ingredientId)" +
                                " VALUES(@recipeId, @itemQty, @ingredientId)";
                            cmd.Parameters.AddWithValue("@recipeId", recipeId);
                            cmd.Parameters.AddWithValue("@itemQty", qty);
                            cmd.Parameters.AddWithValue("@ingredientId", ingrId);
                            cmd.ExecuteNonQuery();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while adding the ingredient to the recipe:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool clearRecipeItems(int recipeId) { // Function to clear all ingredients from recipe
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM recipeitems WHERE recipeId = @recipeId";
                        cmd.Parameters.AddWithValue("@recipeId", recipeId);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while clearing all ingredients from the recipe:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool createRecipe(Recipe recipe) { // Function to create recipe
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO recipes(name, author, type, description, days, lastUpdateBy, lastUpdate)" +
                            " VALUES(@name, @author, @type, @description, @days, @lastUpdateBy, CURRENT_TIMESTAMP())";
                        cmd.Parameters.AddWithValue("@name", recipe.Name);
                        cmd.Parameters.AddWithValue("@author", recipe.Author);
                        cmd.Parameters.AddWithValue("@type", recipe.Type);
                        cmd.Parameters.AddWithValue("@description", recipe.Description);
                        cmd.Parameters.AddWithValue("@days", recipe.Days);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while adding the new recipe:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool deleteRecipe(int id) { // Function to delete recipe
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM recipes WHERE recipeId = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while deleting the recipe:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public DataTable getAllRecipes() { // Function to get all recipes
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM recipes";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting all recipes:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable getAllRecipeItems() { // Function to get all ingredients for all recipes
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT recipeId, itemQty, recipeItems.ingredientId as ingredientId, name, category, type, manufacturer" +
                        " FROM recipeItems INNER JOIN ingredients ON recipeItems.ingredientId = ingredients.ingredientId";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting all ingredients for all recipes:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable getRecipe(int id) { // Function to get all recipes
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM recipes WHERE recipeId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting the recipe:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable getRecipeItems(int id) { // Function to get all the recipe ingredients
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT recipeId, itemQty, recipeItems.ingredientId as ingredientId, name, category, type, manufacturer" +
                        " FROM recipeItems INNER JOIN ingredients ON recipeItems.ingredientId = ingredients.ingredientId" +
                        " WHERE recipeId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while getting the recipe ingredients:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public bool remRecipeItem(int recipeId, int ingrId, int qty) { // Function to delete ingredients from recipe
            int _itemId, _itemQty;
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        // Check to see if an item record already exists for this recipe
                        cmd.CommandText = "SELECT itemId FROM recipeitems WHERE recipeId = @recipeId AND ingredientId = @ingredientId";
                        cmd.Parameters.AddWithValue("@recipeId", recipeId);
                        cmd.Parameters.AddWithValue("@ingredientId", ingrId);
                        if (cmd.ExecuteScalar() != null) {   // If the item already exists, change the qty
                            _itemId = (int)cmd.ExecuteScalar();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "SELECT itemQty FROM recipeitems WHERE itemId = @itemId";
                            cmd.Parameters.AddWithValue("@itemId", _itemId);
                            _itemQty = (int)cmd.ExecuteScalar();
                            _itemQty -= qty;
                            if (_itemQty > 0) {  // If the new qty. is more than 0, update the record 
                                cmd.Parameters.Clear();
                                cmd.CommandText = "UPDATE recipeitems SET itemQty = @itemQty WHERE itemId = @itemId";
                                cmd.Parameters.AddWithValue("@itemQty", _itemQty);
                                cmd.Parameters.AddWithValue("@itemId", _itemId);
                                cmd.ExecuteNonQuery();
                            } else {  // If the new qty. is 0 or less, delete the record 
                                cmd.Parameters.Clear();
                                cmd.CommandText = "DELETE FROM recipeItems WHERE itemId = @itemId";
                                cmd.Parameters.AddWithValue("@itemId", _itemId);
                                cmd.ExecuteNonQuery();
                            }
                        } else {   // If the item doesn't exist, return false to indicate failure
                            MessageBox.Show("An error occurred while adding the ingredient to the recipe:  \n" +
                                "The ingredient you are trying to remove doesn't exist", "ERROR");
                            return false;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while deleting the ingredient from the recipe:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }
        public bool updateRecipe(Recipe recipe) { // Function to update recipe
            using (MySqlConnection conn = Connect()) {
                if (IsConnected) {
                    try {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE recipes SET name = @name, author = @author, type = @type, description = @description," +
                            " days = @days, lastUpdateBy = @lastUpdateBy, lastUpdate = CURRENT_TIMESTAMP() WHERE recipeId = @id";
                        cmd.Parameters.AddWithValue("@name", recipe.Name);
                        cmd.Parameters.AddWithValue("@author", recipe.Author);
                        cmd.Parameters.AddWithValue("@type", recipe.Type);
                        cmd.Parameters.AddWithValue("@description", recipe.Description);
                        cmd.Parameters.AddWithValue("@days", recipe.Days);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", MainForm.userId);
                        cmd.Parameters.AddWithValue("@id", recipe.ID);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while updating the recipe:  " + ex, "ERROR");
                        return false;
                    }
                } else {
                    return false;
                }
                return true;
            }
        }

        // Reports
        public DataTable reportBatchSchedule() { // Function to generate a report of upcoming batch schedule
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT name, startDate, endDate, text FROM batch" +
                        " INNER JOIN batch_seq ON batch.sequence = batch_seq.sequence WHERE batch.sequence < 7 ORDER BY startDate ASC, endDate ASC";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while generating the upcombing batch schedule report:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
        public DataTable reportIngrUsage() { // Function to generate a report of ingredient usage
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Connect()) {
                try {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT batchId, batch.name AS batchName, ingredients.name AS ingrName, category, itemQty, stock" +
                        " FROM batch INNER JOIN recipeitems ON batch.recipeId = recipeitems.recipeId" +
                        " INNER JOIN ingredients ON recipeItems.ingredientId = ingredients.ingredientId" +
                        " ORDER BY batch.batchId ASC";
                    MySqlDataAdapter da = new MySqlDataAdapter {
                        SelectCommand = cmd
                    };
                    da.Fill(dt);
                    return dt;
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while generating the ingredient usage report:  " + ex, "ERROR");
                    return dt;
                }
            }
        }
    }
}
