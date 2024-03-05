-- Mandatory
SET SERVEROUTPUT ON


-- Q1)

@q1_driver_display_when_participated
DELETE FROM PARTICIPATED WHERE DRIVER_ID='324984';
INSERT INTO PARTICIPATED VALUES ('324984','KA20Z2345', 10234, 2213, 1230);


-- Q2)

SELECT q2_func_total_accd_from_year(2024) FROM DUAL;

@q2_func_total_accd_from_year_user_prompt
SELECT q2_func_total_accd_from_year_user_prompt() FROM DUAL;


-- Q3)

@q3_procedure_total_dmg_driver_year
EXEC q3_procedure_total_dmg_driver_year('Arvind D', 2024);
EXEC q3_procedure_total_dmg_driver_year('Rahul Verma', 2020);


-- Q4)

@q4_procedure_accident_data_from_location
EXEC q4_procedure_accident_data_from_location('HP Store, Main Street');

-- multiple records case
EXEC q4_procedure_accident_data_from_location('Delhi');

-- no records case
EXEC q4_procedure_accident_data_from_location('abcdef');
