TYPE=VIEW
query=select `clicom`.`client`.`NCLI` AS `NCLI`,`clicom`.`client`.`NOM` AS `NOM`,`clicom`.`client`.`LOCALITE` AS `LOCALITE`,`clicom`.`client`.`CAT` AS `CAT` from `clicom`.`client` where (`clicom`.`client`.`LOCALITE` = \'Namur\')
md5=235d912d29555064502b66d4ca8fb8e8
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2021-09-21 11:48:52
create-version=1
source=select `client`.`NCLI` AS `NCLI`,`client`.`NOM` AS `NOM`,`client`.`LOCALITE` AS `LOCALITE`,`client`.`CAT` AS `CAT` from `client` where (`client`.`LOCALITE` = \'Namur\')
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `clicom`.`client`.`NCLI` AS `NCLI`,`clicom`.`client`.`NOM` AS `NOM`,`clicom`.`client`.`LOCALITE` AS `LOCALITE`,`clicom`.`client`.`CAT` AS `CAT` from `clicom`.`client` where (`clicom`.`client`.`LOCALITE` = \'Namur\')
