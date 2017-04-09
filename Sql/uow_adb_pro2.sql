/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : uow_adb_pro2

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2017-04-09 00:08:46
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `db_p2_attendance`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_attendance`;
CREATE TABLE `db_p2_attendance` (
  `STU_NUM` int(11) unsigned NOT NULL,
  `COS_ID` int(11) unsigned NOT NULL,
  `ATD_DT` date NOT NULL,
  PRIMARY KEY (`STU_NUM`,`COS_ID`,`ATD_DT`),
  KEY `ATCI` (`COS_ID`),
  CONSTRAINT `ATCI` FOREIGN KEY (`COS_ID`) REFERENCES `db_p2_course` (`COS_ID`),
  CONSTRAINT `ATSN` FOREIGN KEY (`STU_NUM`) REFERENCES `db_p2_student` (`STU_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_attendance
-- ----------------------------
INSERT INTO `db_p2_attendance` VALUES ('17', '1', '2015-12-23');
INSERT INTO `db_p2_attendance` VALUES ('19', '1', '2016-05-04');
INSERT INTO `db_p2_attendance` VALUES ('21', '1', '2017-04-05');
INSERT INTO `db_p2_attendance` VALUES ('27', '1', '2017-03-30');
INSERT INTO `db_p2_attendance` VALUES ('28', '1', '2015-01-03');
INSERT INTO `db_p2_attendance` VALUES ('15', '2', '2017-02-02');
INSERT INTO `db_p2_attendance` VALUES ('22', '2', '2017-01-20');
INSERT INTO `db_p2_attendance` VALUES ('24', '2', '2016-09-02');
INSERT INTO `db_p2_attendance` VALUES ('25', '2', '2016-07-19');
INSERT INTO `db_p2_attendance` VALUES ('2', '3', '2017-04-04');
INSERT INTO `db_p2_attendance` VALUES ('3', '3', '2017-01-03');
INSERT INTO `db_p2_attendance` VALUES ('20', '3', '2016-04-05');
INSERT INTO `db_p2_attendance` VALUES ('23', '3', '2016-10-28');
INSERT INTO `db_p2_attendance` VALUES ('30', '3', '2016-07-15');
INSERT INTO `db_p2_attendance` VALUES ('4', '4', '2016-02-02');
INSERT INTO `db_p2_attendance` VALUES ('26', '4', '2016-06-16');
INSERT INTO `db_p2_attendance` VALUES ('29', '4', '2016-08-07');
INSERT INTO `db_p2_attendance` VALUES ('5', '5', '2016-12-30');
INSERT INTO `db_p2_attendance` VALUES ('10', '5', '2015-03-02');
INSERT INTO `db_p2_attendance` VALUES ('11', '5', '2016-09-11');
INSERT INTO `db_p2_attendance` VALUES ('5', '6', '2017-03-31');
INSERT INTO `db_p2_attendance` VALUES ('5', '6', '2017-04-05');
INSERT INTO `db_p2_attendance` VALUES ('6', '6', '2016-07-19');
INSERT INTO `db_p2_attendance` VALUES ('16', '6', '2017-02-10');
INSERT INTO `db_p2_attendance` VALUES ('9', '7', '2017-03-03');
INSERT INTO `db_p2_attendance` VALUES ('18', '7', '2015-10-30');
INSERT INTO `db_p2_attendance` VALUES ('8', '8', '2017-01-19');
INSERT INTO `db_p2_attendance` VALUES ('13', '8', '2017-01-03');
INSERT INTO `db_p2_attendance` VALUES ('7', '9', '2017-01-03');
INSERT INTO `db_p2_attendance` VALUES ('12', '10', '2017-01-03');
INSERT INTO `db_p2_attendance` VALUES ('14', '10', '2017-04-03');

-- ----------------------------
-- Table structure for `db_p2_course`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_course`;
CREATE TABLE `db_p2_course` (
  `COS_ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `COS_NAME` varchar(100) NOT NULL,
  `COL_ID` smallint(6) unsigned NOT NULL,
  `COS_ACTIVE` bit(1) NOT NULL,
  PRIMARY KEY (`COS_ID`),
  KEY `COCI` (`COL_ID`),
  CONSTRAINT `COCI` FOREIGN KEY (`COL_ID`) REFERENCES `db_p2_courselevel` (`COL_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_course
-- ----------------------------
INSERT INTO `db_p2_course` VALUES ('0000000001', 'Punching introduce', '1', '');
INSERT INTO `db_p2_course` VALUES ('0000000002', 'Punching tranning', '2', '');
INSERT INTO `db_p2_course` VALUES ('0000000003', 'Kicking introduce', '1', '');
INSERT INTO `db_p2_course` VALUES ('0000000004', 'Kicking training', '2', '');
INSERT INTO `db_p2_course` VALUES ('0000000005', 'White&Yellow Level test', '1', '');
INSERT INTO `db_p2_course` VALUES ('0000000006', 'Punching fighting', '3', '');
INSERT INTO `db_p2_course` VALUES ('0000000007', 'Punching competition', '4', '');
INSERT INTO `db_p2_course` VALUES ('0000000008', 'Punching showing', '5', '');
INSERT INTO `db_p2_course` VALUES ('0000000009', 'Training testing', '1', '');
INSERT INTO `db_p2_course` VALUES ('0000000010', 'Yellow level test', '1', '');

-- ----------------------------
-- Table structure for `db_p2_courselevel`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_courselevel`;
CREATE TABLE `db_p2_courselevel` (
  `COL_ID` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `COL_NAME` varchar(100) NOT NULL,
  PRIMARY KEY (`COL_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_courselevel
-- ----------------------------
INSERT INTO `db_p2_courselevel` VALUES ('1', 'Intruducing');
INSERT INTO `db_p2_courselevel` VALUES ('2', 'Beginning');
INSERT INTO `db_p2_courselevel` VALUES ('3', 'Medium');
INSERT INTO `db_p2_courselevel` VALUES ('4', 'Advanced');
INSERT INTO `db_p2_courselevel` VALUES ('5', 'Master');

-- ----------------------------
-- Table structure for `db_p2_member`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_member`;
CREATE TABLE `db_p2_member` (
  `MEM_USR` varchar(50) NOT NULL,
  `MEM_PWD` varchar(50) NOT NULL,
  `MEM_STU` bit(1) NOT NULL,
  `STU_NUM` int(10) unsigned NOT NULL,
  PRIMARY KEY (`MEM_USR`),
  KEY `MSN` (`STU_NUM`),
  CONSTRAINT `MSN` FOREIGN KEY (`STU_NUM`) REFERENCES `db_p2_student` (`STU_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_member
-- ----------------------------
INSERT INTO `db_p2_member` VALUES ('admin', 'admin', '', '1');

-- ----------------------------
-- Table structure for `db_p2_parent`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_parent`;
CREATE TABLE `db_p2_parent` (
  `PAR_NUM` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PAR_NAME` varchar(50) NOT NULL,
  `PAR_MOBILE` varchar(20) NOT NULL,
  `PAR_EMAIL` varchar(50) NOT NULL,
  PRIMARY KEY (`PAR_NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_parent
-- ----------------------------
INSERT INTO `db_p2_parent` VALUES ('1', 'Iva PaPa', '7782838421', 'IvaPa@cmp.ca');
INSERT INTO `db_p2_parent` VALUES ('2', 'Jamal Mom', '2345672772', 'Jamalmom@gmail.com');
INSERT INTO `db_p2_parent` VALUES ('3', 'Marcia Mom', '8746653231', 'Marciamom@sina.com');
INSERT INTO `db_p2_parent` VALUES ('4', 'Joson PaPa', '2267890976', 'JosonPa@123.com');
INSERT INTO `db_p2_parent` VALUES ('5', 'Juli PaPa', '3339585899', 'JuliPa@mail.com');
INSERT INTO `db_p2_parent` VALUES ('6', 'Welian PaPa', '1987475588', 'welianPa@hao123.com');
INSERT INTO `db_p2_parent` VALUES ('7', 'Hao Mom', '3477585843', 'haomom@sina.com');
INSERT INTO `db_p2_parent` VALUES ('8', 'Lida Mom', '6447789987', 'lidaM@gmail.com');
INSERT INTO `db_p2_parent` VALUES ('9', 'Lina PaPa', '6473839387', 'linamom@123.com');
INSERT INTO `db_p2_parent` VALUES ('10', 'Sky Mom', '2267578987', 'skymom@gmail.com');

-- ----------------------------
-- Table structure for `db_p2_payfor`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_payfor`;
CREATE TABLE `db_p2_payfor` (
  `PAF_ID` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `PAF_DES` varchar(100) NOT NULL,
  PRIMARY KEY (`PAF_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_payfor
-- ----------------------------
INSERT INTO `db_p2_payfor` VALUES ('1', 'membership');
INSERT INTO `db_p2_payfor` VALUES ('2', 'tests');
INSERT INTO `db_p2_payfor` VALUES ('3', 'purchasing');
INSERT INTO `db_p2_payfor` VALUES ('4', 'products');

-- ----------------------------
-- Table structure for `db_p2_payment`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_payment`;
CREATE TABLE `db_p2_payment` (
  `PAY_ID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `STU_NUM` int(11) unsigned NOT NULL,
  `PAY_FEE` double NOT NULL,
  `PAF_ID` smallint(6) unsigned NOT NULL,
  `PAY_DT` datetime NOT NULL,
  PRIMARY KEY (`PAY_ID`),
  KEY `SN` (`STU_NUM`) USING BTREE,
  KEY `PYPI` (`PAF_ID`),
  CONSTRAINT `PYPI` FOREIGN KEY (`PAF_ID`) REFERENCES `db_p2_payfor` (`PAF_ID`),
  CONSTRAINT `PYSN` FOREIGN KEY (`STU_NUM`) REFERENCES `db_p2_student` (`STU_NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=86 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_payment
-- ----------------------------
INSERT INTO `db_p2_payment` VALUES ('1', '2', '1500', '1', '2017-04-01 10:55:00');
INSERT INTO `db_p2_payment` VALUES ('2', '3', '300', '2', '2017-04-02 09:30:00');
INSERT INTO `db_p2_payment` VALUES ('3', '4', '1200', '3', '2017-04-02 15:08:00');
INSERT INTO `db_p2_payment` VALUES ('4', '3', '256', '4', '2017-04-02 12:55:00');
INSERT INTO `db_p2_payment` VALUES ('5', '2', '433', '2', '2017-04-02 14:30:00');
INSERT INTO `db_p2_payment` VALUES ('6', '1', '2345', '3', '2017-04-03 09:10:00');
INSERT INTO `db_p2_payment` VALUES ('7', '2', '223', '4', '2017-04-03 09:40:00');
INSERT INTO `db_p2_payment` VALUES ('8', '3', '134', '1', '2017-04-03 10:00:00');
INSERT INTO `db_p2_payment` VALUES ('9', '5', '2000', '2', '2017-04-03 11:30:00');
INSERT INTO `db_p2_payment` VALUES ('10', '17', '567', '1', '2017-04-03 12:02:00');
INSERT INTO `db_p2_payment` VALUES ('11', '18', '876', '3', '2017-04-03 14:20:00');
INSERT INTO `db_p2_payment` VALUES ('12', '20', '234', '4', '2017-04-04 09:11:00');
INSERT INTO `db_p2_payment` VALUES ('13', '15', '988', '3', '2017-04-04 09:30:00');
INSERT INTO `db_p2_payment` VALUES ('14', '13', '777', '2', '2017-04-04 10:40:00');
INSERT INTO `db_p2_payment` VALUES ('15', '6', '544', '1', '2017-04-04 12:30:00');
INSERT INTO `db_p2_payment` VALUES ('16', '9', '234', '3', '2017-04-05 11:20:00');
INSERT INTO `db_p2_payment` VALUES ('17', '10', '123', '3', '2017-04-05 13:29:00');
INSERT INTO `db_p2_payment` VALUES ('18', '7', '1500', '3', '2017-04-05 14:30:00');
INSERT INTO `db_p2_payment` VALUES ('19', '12', '1300', '3', '2017-04-05 15:10:00');
INSERT INTO `db_p2_payment` VALUES ('20', '11', '435', '1', '2017-04-05 15:45:00');
INSERT INTO `db_p2_payment` VALUES ('21', '1', '344', '3', '2017-04-05 16:00:00');
INSERT INTO `db_p2_payment` VALUES ('22', '3', '897', '3', '2017-04-05 16:20:00');
INSERT INTO `db_p2_payment` VALUES ('23', '4', '678', '4', '2017-04-05 17:00:00');
INSERT INTO `db_p2_payment` VALUES ('24', '16', '556', '4', '2017-04-06 09:00:00');
INSERT INTO `db_p2_payment` VALUES ('25', '19', '554', '2', '2017-04-06 09:30:00');
INSERT INTO `db_p2_payment` VALUES ('26', '12', '600', '1', '2017-04-06 09:50:00');
INSERT INTO `db_p2_payment` VALUES ('27', '11', '200', '1', '2017-04-06 10:09:00');
INSERT INTO `db_p2_payment` VALUES ('28', '5', '500', '3', '2017-04-06 11:00:00');
INSERT INTO `db_p2_payment` VALUES ('29', '8', '644', '4', '2017-04-06 11:09:00');
INSERT INTO `db_p2_payment` VALUES ('30', '9', '875', '4', '2017-04-06 12:00:00');
INSERT INTO `db_p2_payment` VALUES ('31', '30', '222', '3', '2017-04-06 12:30:00');
INSERT INTO `db_p2_payment` VALUES ('32', '24', '345', '4', '2017-04-06 00:00:00');
INSERT INTO `db_p2_payment` VALUES ('33', '25', '543', '3', '2017-04-06 17:00:00');
INSERT INTO `db_p2_payment` VALUES ('34', '21', '333', '3', '2017-04-06 17:30:00');
INSERT INTO `db_p2_payment` VALUES ('35', '23', '900', '2', '2017-04-07 10:00:00');
INSERT INTO `db_p2_payment` VALUES ('36', '26', '98', '2', '2017-04-07 11:30:00');
INSERT INTO `db_p2_payment` VALUES ('37', '29', '789', '2', '2017-04-07 12:00:00');
INSERT INTO `db_p2_payment` VALUES ('38', '27', '665', '1', '2017-04-07 12:33:00');
INSERT INTO `db_p2_payment` VALUES ('39', '28', '87', '1', '2017-04-07 13:00:00');
INSERT INTO `db_p2_payment` VALUES ('40', '22', '568', '4', '2017-04-07 13:10:00');
INSERT INTO `db_p2_payment` VALUES ('85', '3', '656', '3', '2017-04-08 15:12:51');

-- ----------------------------
-- Table structure for `db_p2_rank`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_rank`;
CREATE TABLE `db_p2_rank` (
  `RAK_ID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `RAK_NAME` varchar(100) NOT NULL,
  `RAK_COLOR` varchar(255) NOT NULL,
  PRIMARY KEY (`RAK_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_rank
-- ----------------------------
INSERT INTO `db_p2_rank` VALUES ('1', 'White', 'w');
INSERT INTO `db_p2_rank` VALUES ('2', 'White&Yellow', 'wy');
INSERT INTO `db_p2_rank` VALUES ('3', 'Yellow', 'y');
INSERT INTO `db_p2_rank` VALUES ('4', 'Yello&Green', 'yg');
INSERT INTO `db_p2_rank` VALUES ('5', 'Blue&Green', 'bg');
INSERT INTO `db_p2_rank` VALUES ('6', 'Blue', 'b');
INSERT INTO `db_p2_rank` VALUES ('7', 'Blue&Red', 'br');
INSERT INTO `db_p2_rank` VALUES ('8', 'Red', 'r');
INSERT INTO `db_p2_rank` VALUES ('9', 'Black1', 'b1');
INSERT INTO `db_p2_rank` VALUES ('10', 'Black2', 'b2');
INSERT INTO `db_p2_rank` VALUES ('11', 'Black3', 'b3');
INSERT INTO `db_p2_rank` VALUES ('12', 'Black4', 'b4');
INSERT INTO `db_p2_rank` VALUES ('13', 'Black5', 'b5');
INSERT INTO `db_p2_rank` VALUES ('14', 'Black6', 'b6');
INSERT INTO `db_p2_rank` VALUES ('15', 'Black7', 'b7');
INSERT INTO `db_p2_rank` VALUES ('16', 'Black8', 'b8');
INSERT INTO `db_p2_rank` VALUES ('17', 'Black9', 'b9');

-- ----------------------------
-- Table structure for `db_p2_requirement`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_requirement`;
CREATE TABLE `db_p2_requirement` (
  `RAK_ID` int(11) unsigned NOT NULL,
  `COS_ID` int(11) unsigned NOT NULL,
  `REQ_DES` varchar(200) NOT NULL,
  PRIMARY KEY (`RAK_ID`,`COS_ID`),
  KEY `RECI` (`COS_ID`),
  CONSTRAINT `RECI` FOREIGN KEY (`COS_ID`) REFERENCES `db_p2_course` (`COS_ID`),
  CONSTRAINT `RERI` FOREIGN KEY (`RAK_ID`) REFERENCES `db_p2_rank` (`RAK_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_requirement
-- ----------------------------
INSERT INTO `db_p2_requirement` VALUES ('2', '1', '');
INSERT INTO `db_p2_requirement` VALUES ('2', '4', '');
INSERT INTO `db_p2_requirement` VALUES ('2', '5', '');
INSERT INTO `db_p2_requirement` VALUES ('2', '10', '');
INSERT INTO `db_p2_requirement` VALUES ('3', '2', '');
INSERT INTO `db_p2_requirement` VALUES ('3', '4', '');

-- ----------------------------
-- Table structure for `db_p2_student`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_student`;
CREATE TABLE `db_p2_student` (
  `STU_NUM` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `STU_NAME` varchar(50) NOT NULL,
  `STU_BIRTH` date NOT NULL,
  `STU_JODATE` date NOT NULL,
  `STU_MOBILE` varchar(20) NOT NULL,
  `STU_EMAIL` varchar(50) NOT NULL,
  `STU_ADDR` varchar(100) NOT NULL,
  `STU_ACTIVE` bit(1) NOT NULL,
  PRIMARY KEY (`STU_NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_student
-- ----------------------------
INSERT INTO `db_p2_student` VALUES ('1', 'admin', '1900-01-01', '1900-01-01', 'mobile', 'email', 'addr', '');
INSERT INTO `db_p2_student` VALUES ('2', 'Tami', '1996-04-08', '2015-12-14', '5192568492', 'stu1@uadb.ca', '524 Belle Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('3', 'Curt', '1973-09-21', '2017-02-01', '5192948275', 'stu2@cica.ca', '6332 Riverside Rd. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('4', 'Iva', '2000-02-10', '2016-02-02', '2267278898', 'iva@artschool.ca', '233 Parent Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('5', 'Jamal', '2001-02-23', '2016-12-30', '5192229847', 'jamal@artschool.ca', '778 Campbell Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('6', 'Miranda', '1991-04-05', '2016-07-19', '5199984777', 'miranda@artschool.ca', '1004 Partington Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('7', 'Rosario', '1980-03-05', '2017-01-03', '2264553255', 'rosario@artschool.ca', '119 Victori Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('8', 'Mattie', '1998-03-04', '2017-01-19', '2263837474', 'mattie@artschool.ca', '678 Dougall Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('9', 'Clint', '1996-08-09', '2017-03-03', '2264544444', 'clint@artschool.ca', '224 Mercer St.Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('10', 'Lewis', '1978-07-07', '2015-03-02', '5193344454', 'lewis@artschool.ca', '998 Foch Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('11', 'Stacy', '1988-04-10', '2016-09-11', '5197678983', 'stacy@artschool.ca', '290 Highland Ane. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('12', 'Luis', '1999-03-05', '2017-01-03', '2267778930', 'luis@artschool.ca', '222 Church St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('13', 'Minnie', '1992-04-30', '2017-01-03', '5193337658', 'minnie@artschool.ca', '998 Ellis St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('14', 'Zoe', '1990-02-02', '2017-04-03', '5197469583', 'zoe@artschool.ca', '565 Mckay Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('15', 'Joy', '1990-04-02', '2017-02-02', '2269747442', 'joy@artschool.ca', '892 Askin Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('16', 'Seteve', '1978-03-02', '2017-02-10', '2267896452', 'seteve@artschool.ca', '1020 Indian Rd. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('17', 'Marcia', '2003-09-20', '2015-12-23', '2264649765', 'marcia@artschool.ca', '228 California Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('18', 'Joson', '2002-09-02', '2015-10-30', '5193768884', 'joson@artschool.ca', '776 Wigle Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('19', 'Tina', '1997-03-23', '2016-05-04', '5197474442', 'tina@artschool.ca', '988 Brich St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('20', 'Zie', '1986-10-28', '2016-04-05', '2268494344', 'zie@artschool.ca', '983 Vaughan St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('21', 'Juli', '2003-02-06', '2017-04-05', '2265434554', 'juli@artschool.ca', '787 Chuich St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('22', 'Welian', '2003-10-08', '2017-01-20', '2267658767', 'welian@artschool.ca', '738 Josephine Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('23', 'Hao', '2001-09-30', '2016-10-28', '5197488893', 'hao@artschool.ca', ' 128 Mcwan Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('24', 'Xiaopeng', '1998-09-29', '2016-09-02', '2269874334', 'xiaopeng@artschool.ca', ' 299 Wyandotte W. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('25', 'Machile', '1999-06-09', '2016-07-19', '2263338989', 'machile@artschool.ca', ' 567 Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('26', 'Lida', '1999-03-07', '2016-06-16', '5198776421', 'lida@artschool.ca', '288 Ottawa Ave. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('27', 'Lina', '2000-08-08', '2017-03-30', '2268789944', 'lina@artschool.ca', ' 879 King St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('28', 'Huangran', '1997-07-01', '2015-01-03', '5198985858', 'huangran@artschool.ca', ' 865 Queen St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('29', 'Sky', '2001-09-20', '2016-08-07', '5194757583', 'sky@artschool.ca', ' 244 Peter St. Windsor, ON', '');
INSERT INTO `db_p2_student` VALUES ('30', 'Wandhong', '1989-03-08', '2016-07-15', '2268484994', 'wandhong@artschool.ca', ' 122 Sandwich St. Windsor, ON', '');

-- ----------------------------
-- Table structure for `db_p2_stupar`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_stupar`;
CREATE TABLE `db_p2_stupar` (
  `STU_NUM` int(11) unsigned NOT NULL,
  `STP_MORD` bit(1) NOT NULL,
  `STP_STUPAR` bit(1) NOT NULL,
  `SP_ID` int(11) unsigned NOT NULL,
  PRIMARY KEY (`STU_NUM`,`STP_MORD`),
  CONSTRAINT `SPSN` FOREIGN KEY (`STU_NUM`) REFERENCES `db_p2_student` (`STU_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_stupar
-- ----------------------------
INSERT INTO `db_p2_stupar` VALUES ('1', '', '', '1');
INSERT INTO `db_p2_stupar` VALUES ('1', '', '', '1');
INSERT INTO `db_p2_stupar` VALUES ('2', '', '', '3');
INSERT INTO `db_p2_stupar` VALUES ('2', '', '', '1');

-- ----------------------------
-- Table structure for `db_p2_sturank`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_sturank`;
CREATE TABLE `db_p2_sturank` (
  `STU_NUM` int(11) unsigned NOT NULL,
  `RAK_ID` int(11) unsigned NOT NULL,
  `STR_DT` date NOT NULL,
  PRIMARY KEY (`STU_NUM`,`RAK_ID`),
  KEY `SRRI` (`RAK_ID`),
  CONSTRAINT `SRRI` FOREIGN KEY (`RAK_ID`) REFERENCES `db_p2_rank` (`RAK_ID`),
  CONSTRAINT `SRSN` FOREIGN KEY (`STU_NUM`) REFERENCES `db_p2_student` (`STU_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_sturank
-- ----------------------------
INSERT INTO `db_p2_sturank` VALUES ('1', '17', '1900-01-01');
INSERT INTO `db_p2_sturank` VALUES ('2', '1', '2015-12-14');
INSERT INTO `db_p2_sturank` VALUES ('2', '2', '2016-03-03');
INSERT INTO `db_p2_sturank` VALUES ('2', '3', '2016-06-04');
INSERT INTO `db_p2_sturank` VALUES ('2', '4', '2016-09-30');
INSERT INTO `db_p2_sturank` VALUES ('2', '5', '2016-12-31');
INSERT INTO `db_p2_sturank` VALUES ('2', '6', '2017-03-21');
INSERT INTO `db_p2_sturank` VALUES ('3', '1', '2017-02-01');
INSERT INTO `db_p2_sturank` VALUES ('4', '1', '2016-02-02');
INSERT INTO `db_p2_sturank` VALUES ('5', '1', '2016-12-30');
INSERT INTO `db_p2_sturank` VALUES ('6', '1', '2016-07-19');
INSERT INTO `db_p2_sturank` VALUES ('7', '1', '2017-01-03');
INSERT INTO `db_p2_sturank` VALUES ('8', '1', '2017-01-19');
INSERT INTO `db_p2_sturank` VALUES ('9', '1', '2017-03-03');
INSERT INTO `db_p2_sturank` VALUES ('10', '1', '2015-03-02');
INSERT INTO `db_p2_sturank` VALUES ('11', '1', '2016-09-11');
INSERT INTO `db_p2_sturank` VALUES ('12', '1', '2017-01-03');
INSERT INTO `db_p2_sturank` VALUES ('13', '1', '2017-01-03');
INSERT INTO `db_p2_sturank` VALUES ('14', '1', '2017-04-03');
INSERT INTO `db_p2_sturank` VALUES ('15', '1', '2017-02-02');
INSERT INTO `db_p2_sturank` VALUES ('16', '1', '2017-02-10');
INSERT INTO `db_p2_sturank` VALUES ('17', '1', '2015-12-23');
INSERT INTO `db_p2_sturank` VALUES ('18', '1', '2015-10-30');
INSERT INTO `db_p2_sturank` VALUES ('19', '1', '2016-05-04');
INSERT INTO `db_p2_sturank` VALUES ('20', '1', '2016-04-05');
INSERT INTO `db_p2_sturank` VALUES ('21', '1', '2017-04-05');
INSERT INTO `db_p2_sturank` VALUES ('22', '1', '2017-01-20');
INSERT INTO `db_p2_sturank` VALUES ('23', '1', '2016-10-28');
INSERT INTO `db_p2_sturank` VALUES ('24', '1', '2016-09-02');
INSERT INTO `db_p2_sturank` VALUES ('25', '1', '2016-07-19');
INSERT INTO `db_p2_sturank` VALUES ('26', '1', '2016-06-16');
INSERT INTO `db_p2_sturank` VALUES ('27', '1', '2017-03-30');
INSERT INTO `db_p2_sturank` VALUES ('28', '1', '2015-01-03');
INSERT INTO `db_p2_sturank` VALUES ('29', '1', '2016-08-07');
INSERT INTO `db_p2_sturank` VALUES ('30', '1', '2016-07-15');

-- ----------------------------
-- Table structure for `db_p2_timetable`
-- ----------------------------
DROP TABLE IF EXISTS `db_p2_timetable`;
CREATE TABLE `db_p2_timetable` (
  `COS_ID` int(11) unsigned NOT NULL,
  `TIT_DOW` smallint(6) NOT NULL,
  `TIT_DTS` smallint(6) NOT NULL,
  `TIT_DTE` smallint(6) NOT NULL,
  PRIMARY KEY (`COS_ID`,`TIT_DOW`,`TIT_DTS`,`TIT_DTE`),
  CONSTRAINT `TICI` FOREIGN KEY (`COS_ID`) REFERENCES `db_p2_course` (`COS_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_p2_timetable
-- ----------------------------
INSERT INTO `db_p2_timetable` VALUES ('2', '1', '600', '660');
INSERT INTO `db_p2_timetable` VALUES ('3', '1', '690', '720');
INSERT INTO `db_p2_timetable` VALUES ('4', '2', '780', '840');
