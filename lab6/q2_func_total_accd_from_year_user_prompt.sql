SET SERVEROUTPUT ON

CREATE OR REPLACE FUNCTION q2_func_total_accd_from_year_user_prompt
RETURN INT

IS
    search_year INT;
    total_count INT;

BEGIN
    DBMS_OUTPUT.PUT_LINE('Enter search year:');
    search_year := &search_year;

    SELECT
    COUNT(*) INTO total_count
    FROM accident
    WHERE EXTRACT(YEAR FROM accd_date)=search_year;

    DBMS_OUTPUT.PUT_LINE('DEBUG: ' || total_count || ' accidents occured in the year ' || search_year);

    RETURN total_count;
END;
/
