select REGION_ID, count(COUNTRIES.COUNTRY_ID) as countries 
from COUNTRIES
group by REGION_ID; 

select Regions.region_name, count(COUNTRIES.COUNTRY_ID) as countries
from COUNTRIES right join regions
on countries.region_id = regions.region_id
group by REGION_name; 

select COUNTRIES.COUNTRY_NAME, Regions.region_name 
from COUNTRIES right join regions
on countries.region_id = regions.region_id;

select countries.country_name, count(locations.location_ID) as locations
from COUNTRIES join locations
on countries.country_id = locations.country_id
group by countries.country_name; 

select countries.country_name, locations.city as location
from COUNTRIES join locations
on countries.country_id = locations.country_id; 

select regions.region_name
from regions left join countries
on regions.region_id = countries.region_id
where regions.region_id not in (countries.region_id) ;

select distinct(countries.country_name)
from countries left join locations
on countries.country_id <> locations.country_id;

select regions.region_name, countries.country_name, locations.city as location
from regions join countries
on countries.region_id = regions.region_id join locations
on countries.country_id = locations.country_id;

use AurionPro;


go
create function printDate()
returns date
begin
return (select convert(date,GETDATE()));
end
go

print dbo.printDate();

