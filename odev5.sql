select * from film
where title LIKE '%n'
order by length desc
limit 5

select * from film
where title LIKE '%n'
order by length
offset 5
limit 5

select last_name,store_id from customer
where store_id=1
order by last_name
limit 4




