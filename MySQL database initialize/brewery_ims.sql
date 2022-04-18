CREATE SCHEMA `brewery_ims` ;
USE `brewery_ims` ;

SET @@GLOBAL.information_schema_stats_expiry = 0;

CREATE TABLE `users` (
  `userId` int NOT NULL AUTO_INCREMENT,
  `userName` varchar(45) NOT NULL,
  `userPass` varchar(45) NOT NULL,
  `active` tinyint NOT NULL,
  PRIMARY KEY (`userId`),
  UNIQUE KEY `userName_UNIQUE` (`userName`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `users` VALUES (1,'test','test',1);

CREATE TABLE `batch_seq` (
  `sequence` int NOT NULL,
  `text` varchar(50) NOT NULL,
  PRIMARY KEY (`sequence`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `batch_seq` VALUES (0,'Created'),(1,'Ready to Start'),(2,'Mashing'),(3,'Fermenting'),(4,'Racking'),(5,'Cleaning'),(6,'Finished'),(7,'Archived');

CREATE TABLE `ingredients` (
  `ingredientId` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `category` varchar(20) NOT NULL,
  `stock` int NOT NULL,
  `type` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  `alpha` varchar(50) DEFAULT NULL,
  `attenuation` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `unit` varchar(10) NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` int NOT NULL,
  PRIMARY KEY (`ingredientId`),
  KEY `ingr_fk1_idx` (`lastUpdateBy`),
  CONSTRAINT `ingr_fk1` FOREIGN KEY (`lastUpdateBy`) REFERENCES `users` (`userId`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `ingredients` VALUES (1,'Yampula','Yeast',64,'California yeast, dry','Millerite','Powder yeast with high att.',NULL,'95%',NULL,'oz.','2022-03-26 15:48:01',1),(2,'Pilsner','Grain',55,'Barley malt','CNC','Milled grain cracked',NULL,NULL,'Brown','lbs.','2022-03-24 18:02:50',1),(3,'Vienna','Grain',10,'Roasted barley','Guse','Milled grain cracked',NULL,NULL,'Borwn','bag','2022-03-26 15:18:23',1),(4,'Incognito','Hop',66,'Aroma hop','Hopstones','Hops for adding aroma','13.7',NULL,NULL,'lbs.','2022-03-26 15:20:12',1),(5,'Warrior','Hop',100,'Bittering hop','Yakuza Valley','Hops used for bittering','10.9',NULL,NULL,'oz.','2022-03-26 15:21:12',1),(6,'Voss','Yeast',3,'English yeast, liquid','Liquid Bread','A very active yeast from UK',NULL,'30%',NULL,'bag','2022-04-01 10:58:45',1);

CREATE TABLE `equipment` (
  `equipmentId` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `type` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  `status` int NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` int NOT NULL,
  PRIMARY KEY (`equipmentId`),
  KEY `equip_fk1_idx` (`lastUpdateBy`),
  CONSTRAINT `equip_fk1` FOREIGN KEY (`lastUpdateBy`) REFERENCES `users` (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `equipment` VALUES (1,'Tank #1','Fermenter Tank','Tanks R Us','Conical brewing tank',1,'2022-04-01 20:44:16',1),(2,'Tank #2','Fermenter Tank','Tanks R Us','Conical brewing tank',0,'2022-03-26 15:06:05',1),(3,'Tank #3','Fermenter Tank','Tanks R Us','Conical brewing tank',0,'2022-03-26 15:06:08',1),(4,'Mash Tun #1','Mash Tun','Tanks R Us','Mash tun for the conical tanks',0,'2022-03-26 15:07:46',1),(5,'Pump #1','Pump','Eastingroom','Pump to transfer liquids',0,'2022-03-26 15:08:44',1),(6,'Pump #2','Pump','Eastingroom','Pump to transfer liquids',1,'2022-04-01 20:37:54',1),(7,'Pump #3','Pump','Eastingroom','Pump to transfer liquids',0,'2022-03-30 03:49:05',1);

CREATE TABLE `recipes` (
  `recipeId` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `author` varchar(50) DEFAULT NULL,
  `type` varchar(50) NOT NULL,
  `description` varchar(500) DEFAULT NULL,
  `days` int NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` int NOT NULL,
  PRIMARY KEY (`recipeId`),
  KEY `recipe_fk1_idx` (`lastUpdateBy`),
  CONSTRAINT `recipe_fk1` FOREIGN KEY (`lastUpdateBy`) REFERENCES `users` (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `recipes` VALUES (1,'Maibock','Harvey Sanford','Light Bock','Bock typically available in May',45,'2022-03-26 15:54:46',1),(2,'Inronito','Harlow Everest','Amber Ale','Amber ale hopped like IPA with Kolsch yeast',11,'2022-03-31 16:57:59',1),(3,'Light Sinkwater','Jack O\'Neill','American Lager','Traditional style lager very light taste and carbs',38,'2022-04-01 10:58:05',1);

CREATE TABLE `recipeitems` (
  `itemId` int NOT NULL AUTO_INCREMENT,
  `recipeId` int NOT NULL,
  `itemQty` int NOT NULL,
  `ingredientId` int NOT NULL,
  PRIMARY KEY (`itemId`),
  KEY `item_fk1_idx` (`ingredientId`),
  CONSTRAINT `item_fk1` FOREIGN KEY (`ingredientId`) REFERENCES `ingredients` (`ingredientId`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `recipeitems` VALUES (1,1,10,1),(2,3,5,2),(3,3,2,1),(4,3,1,5);

CREATE TABLE `batch` (
  `batchId` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `description` varchar(50) DEFAULT NULL,
  `sequence` int NOT NULL,
  `startDate` date NOT NULL,
  `endDate` date NOT NULL,
  `recipeId` int NOT NULL,
  `lastUpdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `lastUpdateBy` int NOT NULL,
  PRIMARY KEY (`batchId`),
  KEY `batch_fk1_idx` (`lastUpdateBy`) /*!80000 INVISIBLE */,
  KEY `batch_fk2_idx` (`recipeId`),
  KEY `batch_fk3_idx` (`sequence`),
  CONSTRAINT `batch_fk1` FOREIGN KEY (`lastUpdateBy`) REFERENCES `users` (`userId`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `batch_fk2` FOREIGN KEY (`recipeId`) REFERENCES `recipes` (`recipeId`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `batch_fk3` FOREIGN KEY (`sequence`) REFERENCES `batch_seq` (`sequence`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
INSERT INTO `batch` VALUES (1,'Light Sinkwater #1','',3,'2022-03-31','2022-05-08',3,'2022-04-02 01:16:19',1),(2,'Maibock #3','',3,'2022-04-01','2022-05-16',1,'2022-04-03 22:44:42',1),(3,'Inronito #45','Flagship version 45',1,'2022-04-03','2022-04-14',2,'2022-04-02 01:13:55',1),(4,'Inronito #46','Flagship version 46',1,'2022-04-16','2022-04-27',2,'2022-04-02 01:13:55',1);

