
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for chronic
-- ----------------------------
DROP TABLE IF EXISTS `sd_chronic`;
CREATE TABLE `sd_chronic` (
  `HOSPCODE` varchar(5) NOT NULL,
  `PID` varchar(15) NOT NULL,
  `DATE_DIAG` date NOT NULL COMMENT 'วันเดือนปีที่ตรวจพบครั้งแรก',
  `CHRONIC` varchar(6) NOT NULL,
  `HOSP_DX` varchar(5) DEFAULT NULL,
  `HOSP_RX` varchar(5) DEFAULT NULL COMMENT 'รหัสสถานพยาบาลที่ไปรับบริการ',
  `DATE_DISCH` date DEFAULT NULL,
  `TYPEDISCH` varchar(2) NOT NULL,
  `D_UPDATE` datetime NOT NULL,
  PRIMARY KEY (`HOSPCODE`,`PID`,`CHRONIC`),
  KEY `idx1` (`HOSPCODE`,`PID`),
  KEY `idx2` (`CHRONIC`),
  KEY `idx3` (`DATE_DIAG`),
  KEY `idx4` (`HOSP_DX`),
  KEY `idx5` (`HOSP_RX`),
  KEY `idx6` (`DATE_DISCH`),
  KEY `idx7` (`TYPEDISCH`),
  KEY `idx8` (`HOSPCODE`),
  KEY `idx9` (`PID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
