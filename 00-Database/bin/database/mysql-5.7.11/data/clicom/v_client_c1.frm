TYPE=VIEW
query=select `clicom`.`client`.`NCLI` AS `ncli`,`clicom`.`client`.`NOM` AS `nom`,`clicom`.`client`.`LOCALITE` AS `localite`,`clicom`.`client`.`CAT` AS `cat` from `clicom`.`client` where (`clicom`.`client`.`CAT` = \'C1\')
md5=440d2e572c295e0b4b1d01be8fe6886e
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2021-09-21 11:48:52
create-version=1
source=select `client`.`NCLI` AS `ncli`,`client`.`NOM` AS `nom`,`client`.`LOCALITE` AS `localite`,`client`.`CAT` AS `cat` from `client` where (`client`.`CAT` = \'C1\')
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `clicom`.`client`.`NCLI` AS `ncli`,`clicom`.`client`.`NOM` AS `nom`,`clicom`.`client`.`LOCALITE` AS `localite`,`clicom`.`client`.`CAT` AS `cat` from `clicom`.`client` where (`clicom`.`client`.`CAT` = \'C1\')
