-- i)
SELECT COUNT(*) AS 'Accident Count' FROM ACCIDENT WHERE EXTRACT(YEAR FROM ACCD_DATE)=2020;

-- ii)
SELECT 'Tata Tiagor' AS model, COUNT(*) as count FROM participated NATURAL JOIN car WHERE model='Tata Tiagor';
SELECT model, count from (SELECT model, COUNT(*) AS count FROM participated NATURAL JOIN car GROUP BY model) WHERE model='Tata Tigor';
WITH output AS (SELECT model, COUNT(*) AS count FROM participated NATURAL JOIN car GROUP BY model) SELECT * from output WHERE output.model='Tata Tigor';
WITH output(model, regno) AS (SELECT model, regno FROM car WHERE model='Tata Tiagor') SELECT model, COUNT(*) AS COUNT FROM participated,output WHERE output.regno=participated.regno GROUP BY output.model;

-- iii)
SELECT (SELECT name FROM person WHERE driver_id=participated.driver_id) AS DRIVER_NAME, COUNT(*) AS NUMBER_OF_ACCIDENTS, SUM(damage_amount) AS TOTAL_DAMAGE_AMT FROM participated GROUP BY driver_id ORDER BY TOTAL_DAMAGE_AMT DESC;

-- iv)
SELECT * FROM (SELECT (SELECT name FROM person WHERE driver_id=participated.driver_id) AS DRIVER_NAME, COUNT(*) AS NUMBER_OF_ACCIDENTS, SUM(damage_amount) AS TOTAL_DAMAGE_AMT FROM participated GROUP BY driver_id ORDER BY TOTAL_DAMAGE_AMT DESC) WHERE NUMBER_OF_ACCIDENTS > 2;

-- v)
SELECT name FROM person WHERE driver_id IN (SELECT driver_id FROM person MINUS SELECT driver_id from participated);
