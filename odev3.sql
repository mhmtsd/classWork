select country from country 
where country LIKE 'A%a'


select country from country

where  country LIKE '%_____n'

select title from film
WHERE title LIKE '%___t%'

select title,length,rental_rate from film
where title LIKE 'C%' AND length>90
and rental_rate=2.99
