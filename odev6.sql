SELECT ROUND(AVG(rental_rate),3) FROM film;


SELECT count(title) FROM film
where title LIKE 'C%'


SELECT max(LENGTH) FROM film
where rental_rate=0.99

select count(replacement_cost) from film 
where length>150




