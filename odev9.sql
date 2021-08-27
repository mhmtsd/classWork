--city tablosu ile country tablosunda bulunan şehir (city) ve
--ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

select country,city from country
inner join city ci on ci.country_id=country.country_id 


--customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki 
--first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

select first_name,last_name from customer 
inner join payment p on customer.customer_id=p.customer_id
