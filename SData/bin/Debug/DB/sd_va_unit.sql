/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50531
Source Host           : localhost:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-03 15:22:08
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_va_unit
-- ----------------------------
DROP TABLE IF EXISTS `sd_va_unit`;
CREATE TABLE `sd_va_unit` (
  `va_unit_id` int(1) NOT NULL,
  `va_unit_name` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`va_unit_id`),
  KEY `ix_unit` (`va_unit_id`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=tis620;

-- ----------------------------
-- Records of sd_va_unit
-- ----------------------------
INSERT INTO `sd_va_unit` VALUES ('1', 'ฟุต');
INSERT INTO `sd_va_unit` VALUES ('2', 'เมตร');
