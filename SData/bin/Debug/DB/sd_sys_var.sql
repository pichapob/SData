/*
Navicat MySQL Data Transfer

Source Server         : hosxp_pcu
Source Server Version : 50531
Source Host           : 192.168.229.8:3306
Source Database       : hosxp_pcu

Target Server Type    : MYSQL
Target Server Version : 50531
File Encoding         : 65001

Date: 2017-10-20 16:04:31
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for sd_sys_var
-- ----------------------------
DROP TABLE IF EXISTS `sd_sys_var`;
CREATE TABLE `sd_sys_var` (
  `sd_sys_var_id` int(11) NOT NULL,
  `sd_sys_var_name` varchar(200) NOT NULL,
  `sd_sys_var_value` varchar(250) NOT NULL,
  PRIMARY KEY (`sd_sys_var_id`)
) ENGINE=MyISAM DEFAULT CHARSET=tis620;

-- ----------------------------
-- Records of sd_sys_var
-- ----------------------------
INSERT INTO `sd_sys_var` VALUES ('1', 'EXPORT-FOR-VISSION2020', '0');
INSERT INTO `sd_sys_var` VALUES ('2', 'BRHSERVICE-DATA-AUDIT', 'http://203.157.162.18:8080/BRHService/DataAuditService?wsdl');
INSERT INTO `sd_sys_var` VALUES ('3', 'BRHSERVICE-DATA-AUDIT-ACTIVE', 'Y');
