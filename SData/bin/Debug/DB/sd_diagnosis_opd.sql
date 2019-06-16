/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50531
Source Host           : localhost:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-12 17:29:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_diagnosis_opd
-- ----------------------------
DROP TABLE IF EXISTS `sd_diagnosis_opd`;
CREATE TABLE `sd_diagnosis_opd` (
  `HOSPCODE` varchar(5) NOT NULL,
  `PID` varchar(15) NOT NULL,
  `SEQ` varchar(16) NOT NULL,
  `DATE_SERV` date NOT NULL,
  `DIAGTYPE` varchar(1) NOT NULL,
  `DIAGCODE` varchar(6) NOT NULL,
  `CLINIC` varchar(5) NOT NULL,
  `PROVIDER` varchar(15) DEFAULT NULL,
  `D_UPDATE` datetime NOT NULL,
  PRIMARY KEY (`HOSPCODE`,`PID`,`SEQ`,`DATE_SERV`,`DIAGCODE`),
  KEY `idx1` (`HOSPCODE`,`PID`),
  KEY `idx2` (`HOSPCODE`),
  KEY `idx3` (`DATE_SERV`),
  KEY `idx4` (`DIAGTYPE`),
  KEY `idx5` (`DIAGCODE`),
  KEY `idx6` (`CLINIC`),
  KEY `idx7` (`HOSPCODE`,`PROVIDER`),
  KEY `idx8` (`PID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8
/*!50100 PARTITION BY RANGE ( TO_DAYS(`DATE_SERV`))
(PARTITION p2012 VALUES LESS THAN (735050) ENGINE = InnoDB,
 PARTITION p2013 VALUES LESS THAN (735415) ENGINE = InnoDB,
 PARTITION p2014 VALUES LESS THAN (735780) ENGINE = InnoDB,
 PARTITION p2015 VALUES LESS THAN (736145) ENGINE = InnoDB,
 PARTITION p2016 VALUES LESS THAN (736511) ENGINE = InnoDB,
 PARTITION now VALUES LESS THAN MAXVALUE ENGINE = InnoDB) */;
