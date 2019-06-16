
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for death
-- ----------------------------
DROP TABLE IF EXISTS `sd_death`;
CREATE TABLE `sd_death` (
  `HOSPCODE` varchar(5) NOT NULL,
  `PID` varchar(15) NOT NULL,
  `HOSPDEATH` varchar(5) DEFAULT NULL,
  `AN` varchar(9) DEFAULT NULL,
  `SEQ` varchar(16) DEFAULT NULL,
  `ddeath` date NOT NULL,
  `cdeath_a` varchar(6) NOT NULL,
  `CDEATH_B` varchar(6) DEFAULT NULL,
  `CDEATH_C` varchar(6) DEFAULT NULL,
  `CDEATH_D` varchar(6) DEFAULT NULL,
  `ODISEASE` varchar(6) DEFAULT NULL,
  `cdeath` varchar(6) NOT NULL,
  `PREGDEATH` varchar(1) DEFAULT NULL,
  `pdeath` varchar(1) NOT NULL,
  `PROVIDER` varchar(15) DEFAULT NULL,
  `d_update` datetime NOT NULL,
  PRIMARY KEY (`HOSPCODE`,`PID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
