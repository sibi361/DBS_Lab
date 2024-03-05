SET SERVEROUTPUT ON

CREATE OR REPLACE TRIGGER q1_driver_display_when_participated

AFTER INSERT OR UPDATE ON PARTICIPATED
FOR EACH ROW

DECLARE
    new_name VARCHAR(50);
    new_address VARCHAR(200);

BEGIN
    IF INSERTING THEN
        SELECT
            name, address
            INTO new_name, new_address
        FROM person
        WHERE driver_id=:NEW.driver_id;

        DBMS_OUTPUT.PUT_LINE(CHR(10) || 'NEW ACCIDENT REPORT:');
        DBMS_OUTPUT.PUT_LINE('DRIVER NAME: ' || new_name);
        DBMS_OUTPUT.PUT_LINE('DRIVER ADDRESS: ' || new_address);
        DBMS_OUTPUT.PUT_LINE('VEHICLE REG: ' || :NEW.regno);
    END IF;
END;
/
