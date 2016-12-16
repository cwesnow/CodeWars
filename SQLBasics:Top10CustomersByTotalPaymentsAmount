SELECT DISTINCT c.customer_id, c.email, COUNT(amount) AS payments_count, CAST(SUM(amount) AS FLOAT) as total_amount
FROM customer c, payment p
WHERE c.customer_id = p.customer_id
GROUP BY c.customer_id
ORDER BY total_amount DESC
LIMIT 10;
