/*
Navicat MySQL Data Transfer

Source Server         : hosxp_pcu
Source Server Version : 50531
Source Host           : 192.168.229.8:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-20 16:03:52
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_va_list
-- ----------------------------
DROP TABLE IF EXISTS `sd_va_list`;
CREATE TABLE `sd_va_list` (
  `va_id` int(3) NOT NULL AUTO_INCREMENT,
  `va_value` varchar(150) NOT NULL,
  `va_unit` int(1) DEFAULT NULL,
  `va_tranf` int(1) DEFAULT NULL,
  `va_active` varchar(1) NOT NULL,
  `sd_va_vission2020_id` int(11) NOT NULL,
  PRIMARY KEY (`va_id`),
  KEY `ix_value` (`va_value`) USING BTREE,
  KEY `ix_tranf` (`va_tranf`) USING BTREE,
  KEY `ix_unit` (`va_unit`) USING BTREE,
  KEY `ix_sd_va_vission2020_id` (`sd_va_vission2020_id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=tis620;

-- ----------------------------
-- Records of sd_va_list
-- ----------------------------
INSERT INTO `sd_va_list` VALUES ('1', '20/20', '1', '1', 'Y', '1');
INSERT INTO `sd_va_list` VALUES ('2', '20/30', '1', '1', 'Y', '2');
INSERT INTO `sd_va_list` VALUES ('3', '20/40', '1', '1', 'Y', '3');
INSERT INTO `sd_va_list` VALUES ('4', '20/50', '1', '1', 'Y', '4');
INSERT INTO `sd_va_list` VALUES ('5', '20/70', '1', '1', 'Y', '5');
INSERT INTO `sd_va_list` VALUES ('6', '20/100', '1', '1', 'Y', '6');
INSERT INTO `sd_va_list` VALUES ('7', '20/200', '1', '1', 'Y', '7');
INSERT INTO `sd_va_list` VALUES ('8', '15/200', '1', '1', 'Y', '8');
INSERT INTO `sd_va_list` VALUES ('9', '10/200', '1', '2', 'Y', '9');
INSERT INTO `sd_va_list` VALUES ('11', 'CF 3', '1', '2', 'Y', '11');
INSERT INTO `sd_va_list` VALUES ('12', 'CF 2', '1', '2', 'Y', '12');
INSERT INTO `sd_va_list` VALUES ('13', 'CF 1', '1', '2', 'Y', '13');
INSERT INTO `sd_va_list` VALUES ('14', 'HM', '1', '2', 'Y', '15');
INSERT INTO `sd_va_list` VALUES ('15', 'PJ', '1', '2', 'Y', '15');
INSERT INTO `sd_va_list` VALUES ('16', 'PL', '1', '2', 'Y', '16');
INSERT INTO `sd_va_list` VALUES ('17', 'No PL', '1', '2', 'Y', '17');
INSERT INTO `sd_va_list` VALUES ('10', '5/200', '1', '2', 'Y', '10');
INSERT INTO `sd_va_list` VALUES ('29', 'FC', '1', '2', 'Y', '31');
INSERT INTO `sd_va_list` VALUES ('31', '5/200', '1', '2', 'Y', '10');
INSERT INTO `sd_va_list` VALUES ('32', '6/200', '1', '2', 'Y', '10');
