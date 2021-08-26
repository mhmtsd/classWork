SELECT DISTINCT replacement_cost FROM film;

SELECT COUNT (DISTINCT replacement_cost) from film

SELECT count (title)  from film
where title LIKE 'T%' AND rating='G'


SELECT COUNT (DISTINCT COUNTRY) FROM COUNTRY
WHERE COUNTRY LIKE '_____'

SELECT count (DISTINCT CITY) FROM CITY
WHERE CITY LIKE '%r' or CITY LIKE '%R'
