
using Brewery_IMS.Forms;

namespace Brewery_IMS.Classes {
    public class FormMgr {
        private static MainForm _main;
        public static MainForm Main {
            get {
                if (_main == null) {
                    _main = new MainForm();
                }
                return _main;
            }
        }
    }
}
