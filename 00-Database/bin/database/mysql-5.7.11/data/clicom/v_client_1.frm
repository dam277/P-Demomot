TYPE=VIEW
query=select `clicom`.`client`.`NCLI` AS `ncli`,`clicom`.`client`.`NOM` AS `nom`,`clicom`.`client`.`LOCALITE` AS `localite` from `clicom`.`client` order by `clicom`.`client`.`NCLI`
md5=4e355347ca7ef2fced76e9299ffc9766
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2021-09-21 11:48:52
create-version=1
source=select `client`.`NCLI` AS `ncli`,`client`.`NOM` AS `nom`,`client`.`LOCALITE` AS `localite` from `client` order by `client`.`NCLI`
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `clicom`.`client`.`NCLI` AS `ncli`,`clicom`.`client`.`NOM` AS `nom`,`clicom`.`client`.`LOCALITE` AS `localite` from `clicom`.`client` order by `clicom`.`client`.`NCLI`
