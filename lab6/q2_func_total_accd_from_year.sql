SET SERVEROUTPUT ON

CREATE OR REPLACE FUNCTION q2_func_total_accd_from_year
    (SEARCH_YEAR IN INT)
RETURN INT

AS
    total_count INT; 

BEGIN
    SELECT
    COUNT(*) INTO total_count
    FROM ACCIDENT
    WHERE EXTRACT(YEAR FROM ACCD_DATE)=SEARCH_YEAR;

    DBMS_OUTPUT.PUT_LINE('DEBUG: ' || total_count || ' accidents occured in the year ' || SEARCH_YEAR);

    RETURN total_count;
END;
/
