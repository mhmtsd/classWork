--city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte 
--görebileceğimiz LEFT JOIN sorgusunu yazınız.

SELECT c.city,co.country FROM CITY C
LEFT JOIN COUNTRY CO  ON C.country_id=co.country_id

--customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki 
--first_name ve last_name isimlerini
--birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.

select c.first_name,c.last_name from customer c
right join payment p on
c.customer_id=p.payment_id

--customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki 
--first_name ve last_name isimlerini birlikte 
--görebileceğimiz FULL JOIN sorgusunu yazınız.

select r.rental_id, c.first_name,c.last_name from customer c 
full join rental r on c.customer_id=r.customer_id
