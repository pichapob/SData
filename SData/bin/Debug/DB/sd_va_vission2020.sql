/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50531
Source Host           : localhost:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-03 15:22:20
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_va_vission2020
-- ----------------------------
DROP TABLE IF EXISTS `sd_va_vission2020`;
CREATE TABLE `sd_va_vission2020` (
  `sd_va_vission2020_id` int(11) NOT NULL,
  `sd_va_vission2020_value` varchar(50) NOT NULL,
  `sd_va_vission2020_logmar` varchar(255) DEFAULT NULL,
  `sd_va_vission2020_export_id` int(11) NOT NULL,
  `va_unit_id` int(1) NOT NULL,
  PRIMARY KEY (`sd_va_vission2020_id`),
  KEY `ix_sd_va_vission2020_id` (`sd_va_vission2020_id`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=tis620;

-- ----------------------------
-- Records of sd_va_vission2020
-- ----------------------------
INSERT INTO `sd_va_vission2020` VALUES ('1', '20/20', '0', '14', '1');
INSERT INTO `sd_va_vission2020` VALUES ('2', '20/30', '0.18', '6', '1');
INSERT INTO `sd_va_vission2020` VALUES ('3', '20/40', '0.3', '5', '1');
INSERT INTO `sd_va_vission2020` VALUES ('4', '20/50', '0.4', '4', '1');
INSERT INTO `sd_va_vission2020` VALUES ('5', '20/70', '0.54', '3', '1');
INSERT INTO `sd_va_vission2020` VALUES ('6', '20/100', '0.7', '2', '1');
INSERT INTO `sd_va_vission2020` VALUES ('7', '20/200', '1', '1', '1');
INSERT INTO `sd_va_vission2020` VALUES ('8', '15/200', '1.3', '17', '1');
INSERT INTO `sd_va_vission2020` VALUES ('9', '10/200', '1.4', '15', '1');
INSERT INTO `sd_va_vission2020` VALUES ('10', '5/200', '1.58', '16', '1');
INSERT INTO `sd_va_vission2020` VALUES ('11', 'CF 3', '1.9', '7', '1');
INSERT INTO `sd_va_vission2020` VALUES ('12', 'CF 2', '1.9', '8', '1');
INSERT INTO `sd_va_vission2020` VALUES ('13', 'CF 1', '1.9', '9', '1');
INSERT INTO `sd_va_vission2020` VALUES ('14', 'HM', '1.9', '10', '1');
INSERT INTO `sd_va_vission2020` VALUES ('15', 'PJ', '3', '11', '1');
INSERT INTO `sd_va_vission2020` VALUES ('16', 'PL', '3', '12', '1');
INSERT INTO `sd_va_vission2020` VALUES ('17', 'no PL', '4', '13', '1');
INSERT INTO `sd_va_vission2020` VALUES ('18', '6/6', '0', '14', '2');
INSERT INTO `sd_va_vission2020` VALUES ('19', '6/9', '0.18', '6', '2');
INSERT INTO `sd_va_vission2020` VALUES ('20', '6/12', '0.3', '5', '2');
INSERT INTO `sd_va_vission2020` VALUES ('21', '6/18', '0.4', '4', '2');
INSERT INTO `sd_va_vission2020` VALUES ('22', '624', '0.54', '3', '2');
INSERT INTO `sd_va_vission2020` VALUES ('23', '6/36', '0.7', '2', '2');
INSERT INTO `sd_va_vission2020` VALUES ('24', '6/60', '1', '1', '2');
INSERT INTO `sd_va_vission2020` VALUES ('25', '5/60', '1.3', '17', '2');
INSERT INTO `sd_va_vission2020` VALUES ('26', '4/60', '1.35', '18', '2');
INSERT INTO `sd_va_vission2020` VALUES ('27', '3/60', '1.4', '15', '2');
INSERT INTO `sd_va_vission2020` VALUES ('28', '2/60', '1.58', '16', '2');
INSERT INTO `sd_va_vission2020` VALUES ('29', 'CF 3', '1.9', '7', '2');
INSERT INTO `sd_va_vission2020` VALUES ('30', 'CF 2', '1.9', '8', '2');
INSERT INTO `sd_va_vission2020` VALUES ('31', 'CF 1', '1.9', '9', '2');
INSERT INTO `sd_va_vission2020` VALUES ('32', 'HM', '1.9', '10', '2');
INSERT INTO `sd_va_vission2020` VALUES ('33', 'PJ', '3', '11', '2');
INSERT INTO `sd_va_vission2020` VALUES ('34', 'PL', '3', '12', '2');
INSERT INTO `sd_va_vission2020` VALUES ('35', 'no PL', '4', '13', '2');
