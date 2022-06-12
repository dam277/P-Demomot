-- *********************************************
-- * SQL MySQL generation                      
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.2              
-- * Generator date: Sep 14 2021              
-- * Generation date: Sat Jun 11 22:54:28 2022 
-- * LUN file: C:\Users\damis\Desktop\developpement\01-Github\01-Projets\P-Demomot\01-Documents\01-Shemas\03-SQL\P-DemomotDB.lun 
-- * Schema: MLD/1-1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database MLD;
use MLD;


-- Tables Section
-- _____________ 

create table t_character (
     idCharacter int not null auto_increment,
     chaName varchar(100) not null,
     chaModel varchar(100) not null,
     chaLevel int not null,
     chaLife int not null,
     chaGame int not null,
     idUser int not null,
     idRarity int not null,
     constraint ID_t_character_ID primary key (idCharacter));

create table t_power (
     idPower int not null auto_increment,
     powName varchar(100) not null,
     powDescription varchar(255) not null,
     powDamages float(5) not null,
     powLoadTurns int not null,
     powNbTurns int not null,
     powPercentageUpPerHit int not null,
     powPercentageUpPerKill int not null,
     powIsUltime char not null,
     idCharacter int not null,
     constraint ID_t_power_ID primary key (idPower));

create table t_session (
     idSession int not null auto_increment,
     idUser int not null,
     constraint ID_t_session_ID primary key (idSession),
     constraint FKt_isPartOf_ID unique (idUser));

create table t_game (
     idGame int not null auto_increment,
     gamName varchar(100) not null,
     gamOpponent varchar(100) not null,
     gamIsWin char not null,
     constraint ID_t_game_ID primary key (idGame));

create table t_chest (
     idChest int not null auto_increment,
     cheNbrChance int not null,
     idRarity int not null,
     idUser int not null,
     constraint ID_t_chest_ID primary key (idChest));

create table t_play (
     idGame int not null,
     idUser int not null,
     constraint ID_t_play_ID primary key (idGame, idUser));

create table t_rank (
     idRank int not null auto_increment,
     ranName varchar(100) not null,
     ranPoints int not null,
     constraint ID_t_rank_ID primary key (idRank));

create table t_rarity (
     idRarity int not null auto_increment,
     rarName varchar(100) not null,
     rarUpgradePriceLvlOne int not null,
     rarUpgradePriceLvlTwo int not null,
     rarUpgradeCardsLvlOne int not null,
     rarUpgradeCardsLvlTwo int not null,
     rarColor varchar(100) not null,
     constraint ID_t_rarity_ID primary key (idRarity));

create table t_user (
     idUser int not null auto_increment,
     useNickname varchar(100) not null,
     usePasswordHash varchar(100) not null,
     useEntryDate date not null,
     usePermLevel int not null,
     idRank int not null,
     constraint ID_t_user_ID primary key (idUser));


-- Constraints Section
-- ___________________ 

-- Not implemented
-- alter table t_character add constraint ID_t_character_CHK
--     check(exists(select * from t_power
--                  where t_power.idCharacter = idCharacter)); 

alter table t_character add constraint FKt_own_FK
     foreign key (idUser)
     references t_user (idUser);

alter table t_character add constraint FKt_contain_FK
     foreign key (idRarity)
     references t_rarity (idRarity);

alter table t_power add constraint FKt_use_FK
     foreign key (idCharacter)
     references t_character (idCharacter);

alter table t_session add constraint FKt_isPartOf_FK
     foreign key (idUser)
     references t_user (idUser);

-- Not implemented
-- alter table t_game add constraint ID_t_game_CHK
--     check(exists(select * from t_play
--                  where t_play.idGame = idGame)); 

alter table t_chest add constraint FKt_categorize_FK
     foreign key (idRarity)
     references t_rarity (idRarity);

alter table t_chest add constraint FKt_belong_FK
     foreign key (idUser)
     references t_user (idUser);

alter table t_play add constraint FKt_p_t_u_FK
     foreign key (idUser)
     references t_user (idUser);

alter table t_play add constraint FKt_p_t_g
     foreign key (idGame)
     references t_game (idGame);

alter table t_user add constraint FKt_be_FK
     foreign key (idRank)
     references t_rank (idRank);


-- Index Section
-- _____________ 

create unique index ID_t_character_IND
     on t_character (idCharacter);

create index FKt_own_IND
     on t_character (idUser);

create index FKt_contain_IND
     on t_character (idRarity);

create unique index ID_t_power_IND
     on t_power (idPower);

create index FKt_use_IND
     on t_power (idCharacter);

create unique index ID_t_session_IND
     on t_session (idSession);

create unique index FKt_isPartOf_IND
     on t_session (idUser);

create unique index ID_t_game_IND
     on t_game (idGame);

create unique index ID_t_chest_IND
     on t_chest (idChest);

create index FKt_categorize_IND
     on t_chest (idRarity);

create index FKt_belong_IND
     on t_chest (idUser);

create unique index ID_t_play_IND
     on t_play (idGame, idUser);

create index FKt_p_t_u_IND
     on t_play (idUser);

create unique index ID_t_rank_IND
     on t_rank (idRank);

create unique index ID_t_rarity_IND
     on t_rarity (idRarity);

create unique index ID_t_user_IND
     on t_user (idUser);

create index FKt_be_IND
     on t_user (idRank);

