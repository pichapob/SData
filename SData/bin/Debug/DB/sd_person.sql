/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50531
Source Host           : localhost:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-12 17:29:18
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_person
-- ----------------------------
DROP TABLE IF EXISTS `sd_person`;
CREATE TABLE `sd_person` (
  `HOSPCODE` varchar(5) NOT NULL,
  `CID` varchar(13) DEFAULT NULL,
  `PID` varchar(15) NOT NULL,
  `HID` varchar(14) DEFAULT NULL,
  `PRENAME` varchar(3) NOT NULL,
  `NAME` varchar(50) NOT NULL,
  `LNAME` varchar(50) NOT NULL,
  `HN` varchar(15) DEFAULT NULL,
  `SEX` varchar(1) NOT NULL,
  `BIRTH` date NOT NULL,
  `MSTATUS` char(1) DEFAULT NULL,
  `OCCUPATION_OLD` varchar(3) DEFAULT NULL,
  `OCCUPATION_NEW` varchar(4) DEFAULT NULL,
  `RACE` varchar(3) DEFAULT NULL,
  `NATION` varchar(3) NOT NULL,
  `RELIGION` varchar(2) DEFAULT NULL,
  `EDUCATION` varchar(2) DEFAULT NULL,
  `FSTATUS` varchar(1) DEFAULT NULL,
  `FATHER` varchar(13) DEFAULT NULL,
  `MOTHER` varchar(13) DEFAULT NULL,
  `COUPLE` varchar(13) DEFAULT NULL,
  `VSTATUS` varchar(1) DEFAULT NULL,
  `MOVEIN` date DEFAULT NULL,
  `DISCHARGE` varchar(1) DEFAULT NULL,
  `DDISCHARGE` date DEFAULT NULL,
  `ABOGROUP` varchar(1) DEFAULT NULL,
  `RHGROUP` varchar(1) DEFAULT NULL,
  `LABOR` varchar(2) DEFAULT NULL,
  `PASSPORT` varchar(8) DEFAULT NULL,
  `TYPEAREA` varchar(1) NOT NULL,
  `D_UPDATE` datetime NOT NULL,
  PRIMARY KEY (`HOSPCODE`,`PID`),
  KEY `ix_cid` (`CID`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
