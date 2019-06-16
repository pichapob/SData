/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50531
Source Host           : localhost:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-03 15:22:00
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_va_tranf
-- ----------------------------
DROP TABLE IF EXISTS `sd_va_tranf`;
CREATE TABLE `sd_va_tranf` (
  `va_tranf_id` int(1) NOT NULL,
  `va_tranf_desc` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`va_tranf_id`),
  KEY `ix_tranf` (`va_tranf_id`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=tis620;

-- ----------------------------
-- Records of sd_va_tranf
-- ----------------------------
INSERT INTO `sd_va_tranf` VALUES ('1', 'มองเห็น');
INSERT INTO `sd_va_tranf` VALUES ('2', 'มองไม่เห็น');
