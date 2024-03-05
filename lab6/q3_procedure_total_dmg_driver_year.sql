SET SERVEROUTPUT ON

CREATE OR REPLACE PROCEDURE q3_procedure_total_dmg_driver_year
    (
        SEARCH_DRIVER_NAME IN VARCHAR,
        SEARCH_YEAR IN INT
    )

AS
    total_dmg_amt INT;

BEGIN
    SELECT SUM(damage_amount) INTO total_dmg_amt
    FROM participated
        NATURAL JOIN accident
        NATURAL JOIN person
    WHERE name=SEARCH_DRIVER_NAME AND
    EXTRACT(YEAR FROM accd_date)=SEARCH_YEAR;

    IF ( total_dmg_amt IS NULL ) THEN
        total_dmg_amt := 0;
    END IF;

    DBMS_OUTPUT.PUT_LINE(CHR(10) || 'DRIVER NAME: ' || SEARCH_DRIVER_NAME);
    DBMS_OUTPUT.PUT_LINE('YEAR: ' || SEARCH_YEAR);
    DBMS_OUTPUT.PUT_LINE('TOTAL DAMAGE AMOUNT: ' || total_dmg_amt);
END;
/
