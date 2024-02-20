create database [EsemkaEsport]
go 
use [EsemkaEsport]
go

create table [user](
[id]				int				primary key	identity		NOT NULL,
[username]			varchar(50)		NOT NULL,
[password]			varchar(50)		NOT NULL,
[birthdate]			date			NOT NULL,
[gender]			bit				NOT NULL, /* 1 for male, 0 for female */
[Role]				bit				NOT NULL, /* 1 for customer, 0 for admin */
created_at			DATETIME		NOT NULL	DEFAULT CURRENT_TIMESTAMP,
updated_at			DATETIME,
deleted_at			DATETIME,
)

create table [player](
[id]				int				primary key	identity		NOT NULL,
[name]				varchar(50)		NOT NULL,
[nick_name]			varchar(50)		NOT NULL,
[birthdate]			date			NOT NULL,
created_at			DATETIME		NOT NULL	DEFAULT CURRENT_TIMESTAMP,
updated_at			DATETIME,
deleted_at			DATETIME,
)

create table [team](
[id]				int				primary key	identity		NOT NULL,
[team_name]			varchar(50)		NOT NULL,
[company_name]		varchar(50)		NOT NULL,
created_at			DATETIME		NOT NULL	DEFAULT CURRENT_TIMESTAMP,
updated_at			DATETIME,
deleted_at			DATETIME,
)

create table [team_detail](
[id]				int				primary key	identity		NOT NULL,
[team_id]			int				NOT NULL,
[player_id]			int				NOT NULL,
created_at			DATETIME		NOT NULL	DEFAULT CURRENT_TIMESTAMP,
updated_at			DATETIME,
deleted_at			DATETIME,
foreign key([team_id])				references [team]([id]),
foreign key([player_id])			references [player]([id])
)

create table [schedule](
[id]				int				primary key	identity		NOT NULL,
[home_team_id]		int				NOT NULL,
[away_team_id]		int				NOT NULL,
[time]				datetime2(7)	NOT NULL,
created_at			DATETIME		NOT NULL	DEFAULT CURRENT_TIMESTAMP,
updated_at			DATETIME,
deleted_at			DATETIME,
foreign key([home_team_id])				references [team]([id]),
foreign key([away_team_id])				references [team]([id]),
)

create table [schedule_detail](
[id]				int				primary key	identity		NOT NULL,
[schedule_id]		int				NOT NULL,
[user_id]			int				NOT NULL,
[total_ticket]		int				NOT NULL,
created_at			DATETIME		NOT NULL	DEFAULT CURRENT_TIMESTAMP,
updated_at			DATETIME,
deleted_at			DATETIME,
foreign key([schedule_id])				references [schedule]([id]),
foreign key([user_id])					references [user]([id]),
)

insert into [user] ([username], [password], [birthdate], [gender], [role]) values ('admin', 'admin123', '1977-10-03', 1, 0)
insert into [user] ([username], [password], [birthdate], [gender], [role]) values ('steve', '112233', '1999-10-9', 1, 1)
insert into [user] ([username], [password], [birthdate], [gender], [role]) values ('tasya', '332211', '2001-2-23', 0, 1)
insert into [user] ([username], [password], [birthdate], [gender], [role]) values ('anton', '223311', '2003-9-14', 1, 1)

insert into [player] ([nick_name], [name], [birthdate]) values ('eauthers0', 'Elyse Authers', '1990-08-02');
insert into [player] ([nick_name], [name], [birthdate]) values ('hslidders1', 'Hanna Slidders', '1993-08-24');
insert into [player] ([nick_name], [name], [birthdate]) values ('dgreystock2', 'Deloris Greystock', '1993-12-04');
insert into [player] ([nick_name], [name], [birthdate]) values ('klitherland3', 'Kore Litherland', '2005-01-11');
insert into [player] ([nick_name], [name], [birthdate]) values ('lmacscherie4', 'Laura MacScherie', '2006-04-24');
insert into [player] ([nick_name], [name], [birthdate]) values ('kbelcham5', 'Kaile Belcham', '1999-07-08');
insert into [player] ([nick_name], [name], [birthdate]) values ('pmowle6', 'Pall Mowle', '2005-06-29');
insert into [player] ([nick_name], [name], [birthdate]) values ('lpond7', 'Lorene Pond', '1993-05-15');
insert into [player] ([nick_name], [name], [birthdate]) values ('ksimison8', 'Kristi Simison', '1993-05-25');
insert into [player] ([nick_name], [name], [birthdate]) values ('blyall9', 'Berton Lyall', '2000-08-05');
insert into [player] ([nick_name], [name], [birthdate]) values ('besleya', 'Biddy Esley', '1997-06-28');
insert into [player] ([nick_name], [name], [birthdate]) values ('dfayersb', 'Dav Fayers', '1994-05-03');
insert into [player] ([nick_name], [name], [birthdate]) values ('dfarressc', 'Darill Farress', '1999-03-11');
insert into [player] ([nick_name], [name], [birthdate]) values ('epieperd', 'Evelin Pieper', '1990-07-21');
insert into [player] ([nick_name], [name], [birthdate]) values ('okennione', 'Odelle Kennion', '2002-12-16');
insert into [player] ([nick_name], [name], [birthdate]) values ('mlindemanf', 'Marsiella Lindeman', '2003-10-18');
insert into [player] ([nick_name], [name], [birthdate]) values ('gellyattg', 'Geri Ellyatt', '2000-07-26');
insert into [player] ([nick_name], [name], [birthdate]) values ('dofarrellh', 'Dani O''Farrell', '2000-06-02');
insert into [player] ([nick_name], [name], [birthdate]) values ('kscopesi', 'Kyla Scopes', '1995-08-24');
insert into [player] ([nick_name], [name], [birthdate]) values ('cschwierj', 'Corilla Schwier', '2007-06-19');
insert into [player] ([nick_name], [name], [birthdate]) values ('ggregolink', 'Genevieve Gregolin', '1998-12-26');
insert into [player] ([nick_name], [name], [birthdate]) values ('dautyl', 'Daniel Auty', '2004-12-09');
insert into [player] ([nick_name], [name], [birthdate]) values ('bzarbm', 'Beatriz Zarb', '2000-02-24');
insert into [player] ([nick_name], [name], [birthdate]) values ('plinkletern', 'Perceval Linkleter', '1991-01-05');
insert into [player] ([nick_name], [name], [birthdate]) values ('nmeachero', 'Nelly Meacher', '1991-06-01');
insert into [player] ([nick_name], [name], [birthdate]) values ('dclarkep', 'Demetrius Clarke', '2002-10-17');
insert into [player] ([nick_name], [name], [birthdate]) values ('vfarfolomeevq', 'Vitoria Farfolomeev', '1990-12-06');
insert into [player] ([nick_name], [name], [birthdate]) values ('mgoodbournr', 'Maxie Goodbourn', '1993-02-10');
insert into [player] ([nick_name], [name], [birthdate]) values ('jbeldings', 'Jesus Belding', '2004-07-23');
insert into [player] ([nick_name], [name], [birthdate]) values ('mkleinert', 'Myra Kleiner', '1996-12-28');
insert into [player] ([nick_name], [name], [birthdate]) values ('gfairyu', 'Geneva Fairy', '1991-06-26');
insert into [player] ([nick_name], [name], [birthdate]) values ('jhecksv', 'Johannah Hecks', '2002-02-02');
insert into [player] ([nick_name], [name], [birthdate]) values ('mmcw', 'Malinda Mc Coughan', '2006-10-21');
insert into [player] ([nick_name], [name], [birthdate]) values ('lisleyx', 'Lurette Isley', '2004-06-18');
insert into [player] ([nick_name], [name], [birthdate]) values ('fcoldicotty', 'Field Coldicott', '1995-05-19');
insert into [player] ([nick_name], [name], [birthdate]) values ('abeadhamz', 'Anders Beadham', '1999-09-23');


insert into [team] ([team_name], [company_name]) values ('HOSHI', 'RRQ')
insert into [team] ([team_name], [company_name]) values ('LEGEND', 'EVOS')
insert into [team] ([team_name], [company_name]) values ('NIGHT', 'ONIC')
insert into [team] ([team_name], [company_name]) values ('DARK', 'SECREAT')
insert into [team] ([team_name], [company_name]) values ('SILENT', 'BLACK')
insert into [team] ([team_name], [company_name]) values ('LIGHT', 'GEEK')

insert into [team_detail] ([team_id], [player_id]) values (1, 1)
insert into [team_detail] ([team_id], [player_id]) values (1, 2)
insert into [team_detail] ([team_id], [player_id]) values (1, 3)
insert into [team_detail] ([team_id], [player_id]) values (1, 4)
insert into [team_detail] ([team_id], [player_id]) values (1, 5)
insert into [team_detail] ([team_id], [player_id]) values (1, 6)
insert into [team_detail] ([team_id], [player_id]) values (2, 7)
insert into [team_detail] ([team_id], [player_id]) values (2, 8)
insert into [team_detail] ([team_id], [player_id]) values (2, 9)
insert into [team_detail] ([team_id], [player_id]) values (2, 10)
insert into [team_detail] ([team_id], [player_id]) values (2, 11)
insert into [team_detail] ([team_id], [player_id]) values (2, 12)
insert into [team_detail] ([team_id], [player_id]) values (3, 13)
insert into [team_detail] ([team_id], [player_id]) values (3, 14)
insert into [team_detail] ([team_id], [player_id]) values (3, 15)
insert into [team_detail] ([team_id], [player_id]) values (3, 16)
insert into [team_detail] ([team_id], [player_id]) values (3, 17)
insert into [team_detail] ([team_id], [player_id]) values (3, 18)
insert into [team_detail] ([team_id], [player_id]) values (4, 19)
insert into [team_detail] ([team_id], [player_id]) values (4, 20)
insert into [team_detail] ([team_id], [player_id]) values (4, 21)
insert into [team_detail] ([team_id], [player_id]) values (4, 22)
insert into [team_detail] ([team_id], [player_id]) values (4, 23)
insert into [team_detail] ([team_id], [player_id]) values (4, 24)
insert into [team_detail] ([team_id], [player_id]) values (5, 25)
insert into [team_detail] ([team_id], [player_id]) values (5, 26)
insert into [team_detail] ([team_id], [player_id]) values (5, 27)
insert into [team_detail] ([team_id], [player_id]) values (5, 28)
insert into [team_detail] ([team_id], [player_id]) values (5, 29)
insert into [team_detail] ([team_id], [player_id]) values (5, 30)
insert into [team_detail] ([team_id], [player_id]) values (6, 31)
insert into [team_detail] ([team_id], [player_id]) values (6, 32)
insert into [team_detail] ([team_id], [player_id]) values (6, 33)
insert into [team_detail] ([team_id], [player_id]) values (6, 34)
insert into [team_detail] ([team_id], [player_id]) values (6, 35)
insert into [team_detail] ([team_id], [player_id]) values (6, 36)

insert into [schedule] ([home_team_id], [away_team_id], [time]) values (1, 2, '2023-05-28 09:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (3, 4, '2023-05-28 13:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (5, 6, '2023-05-28 17:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (1, 4, '2023-05-29 09:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (2, 5, '2023-05-29 13:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (3, 6, '2023-05-29 17:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (1, 6, '2023-05-30 09:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (2, 4, '2023-05-30 13:00')
insert into [schedule] ([home_team_id], [away_team_id], [time]) values (3, 5, '2023-05-30 17:00')

insert into [schedule_detail] ([schedule_id], [user_id], [total_ticket]) values (1, 2, 3)
insert into [schedule_detail] ([schedule_id], [user_id], [total_ticket]) values (1, 3, 4)
insert into [schedule_detail] ([schedule_id], [user_id], [total_ticket]) values (1, 4, 5)



