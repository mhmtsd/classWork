select rating from film
group by rating

select count(replacement_cost) from film 
group by replacement_cost
having count(replacement_cost)>50


select sum(customer_id) from customer
group by store_id

select country_id,count(*) from city
group by country_id
order by count(*)  desc 
limit 1
