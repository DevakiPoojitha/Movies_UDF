use MyDb

create table udf_movies(movie_id int , horror_movies varchar(20) , kids_movies varchar(15))

insert into udf_movies values (201,'annabelle','jungle book')
insert into udf_movies values (202,'The conjuring','The sea beast')
insert into udf_movies values (203,'The witch','The bad guys')
insert into udf_movies values (204,'The Ring','Cindrella')

select * from udf_movies

CREATE FUNCTION movies_list()
RETURNS TABLE AS
RETURN
select horror_movies,kids_movies from udf_movies
select * from movies_list()