SET SERVEROUTPUT ON

CREATE OR REPLACE PROCEDURE q4_procedure_accident_data_from_location
    (
        SEARCH_LOCATION IN VARCHAR
    )

AS
    ROW_REG VARCHAR(100);
    ROW_DRIVER_NAME VARCHAR(100);
    ROW_DMG_AMT INT;
    ROW_ACCD_DATE VARCHAR(100);

BEGIN
    FOR ROW IN (
        SELECT name DRIVER_NAME, regno REG, damage_amount DMG_AMT, accd_date ACCD_DATE
        FROM participated
            NATURAL JOIN accident
            NATURAL JOIN person
        WHERE location LIKE '%' || SEARCH_LOCATION || '%'
    )

    LOOP
    DBMS_OUTPUT.PUT_LINE(CHR(10) || 'DRIVER NAME: ' || ROW.DRIVER_NAME);
    DBMS_OUTPUT.PUT_LINE('VEHICLE REG NO: ' || ROW.REG);
    DBMS_OUTPUT.PUT_LINE('DAMAGE AMOUNT: ' || ROW.DMG_AMT);
    DBMS_OUTPUT.PUT_LINE('ACCIDENT DATE: ' || ROW.ACCD_DATE);
    END LOOP;

EXCEPTION
    WHEN NO_DATA_FOUND
    THEN
        DBMS_OUTPUT.PUT_LINE(CHR(10) || 'No accident record found for this location.');

END;
/
