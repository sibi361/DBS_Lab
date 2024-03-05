-- i)
CREATE TABLE STUDENT (
    REGNO VARCHAR(20),
    NAME VARCHAR(50),
    MAJOR VARCHAR(50),
    BDATE DATE,
    PRIMARY KEY (REGNO)
);

CREATE TABLE COURSE (
    COURSE# INT,
    CNAME VARCHAR(30),
    DEPT VARCHAR(30),
    PRIMARY KEY (COURSE#)
);

CREATE TABLE TEXT (
    BOOK_ISBN INT,
    BOOKTITLE VARCHAR(50),
    PUBLISHER VARCHAR(50),
    AUTHOR VARCHAR(50),
    PRIMARY KEY (BOOK_ISBN)
);

CREATE TABLE ENROLL (
    REGNO VARCHAR(20),
    COURSE# INT,
    SEM INT,
    BOOK_ISBN INT,
    PRIMARY KEY (REGNO, COURSE#),
    FOREIGN KEY (REGNO) REFERENCES STUDENT,
    FOREIGN KEY (COURSE#) REFERENCES COURSE,
    FOREIGN KEY (BOOK_ISBN) REFERENCES TEXT
);

CREATE TABLE BOOK_ADOPTION (
    COURSE# INT,
    SEM INT,
    BOOK_ISBN INT,
    PRIMARY KEY(COURSE#, SEM, BOOK_ISBN),
    FOREIGN KEY (COURSE#) REFERENCES COURSE,
    FOREIGN KEY (BOOK_ISBN) REFERENCES TEXT
);


-- ii)
INSERT INTO STUDENT VALUES ('220911123', 'Rohan Verma', 'Information Technology', '02-Jan-2003');
INSERT INTO STUDENT VALUES ('220911456', 'Karan Rathod', 'Information Technology', '11-Mar-2003');
INSERT INTO STUDENT VALUES ('220911789', 'Sachi Singh', 'Information Technology', '29-Feb-2004');
INSERT INTO STUDENT VALUES ('220953321', 'Manan Singh', 'Computer and Communication Engineering', '12-Sep-2005');
INSERT INTO STUDENT VALUES ('220953234', 'Aarav Douglas', 'Computer and Communication Engineering', '25-Nov-2005');
INSERT INTO STUDENT VALUES ('220382249', 'Neki Saul', 'Mechanical', '21-Mar-2002');
INSERT INTO STUDENT VALUES ('220382250', 'Neki Saul II', 'AIML', '01-Apr-2002');
SELECT * FROM STUDENT;
COMMIT;

INSERT INTO COURSE VALUES (2122, 'Database Systems', 'ICT');
INSERT INTO COURSE VALUES (2123, 'Embedded Systems', 'ICT');
INSERT INTO COURSE VALUES (2124, 'Engineering Mathematics', 'Mathematics');
INSERT INTO COURSE VALUES (2125, 'Essentials of Management', 'Humanities');
INSERT INTO COURSE VALUES (2126, 'Internet of Things', 'Humanities');
SELECT * FROM COURSE;
COMMIT;

INSERT INTO TEXT VALUES (100131211754, 'Essentials of DBMS', 'Harper Collins', 'Anany Levitin');
INSERT INTO TEXT VALUES (100131212575, 'Basics of ARM Assembly', 'Harper Collins', 'Ronald Maltrice');
INSERT INTO TEXT VALUES (100323121175, 'Probability and Statistics', 'Machmillan', 'Pyglot Stelinky');
INSERT INTO TEXT VALUES (100132112043, 'Managing the Management', 'Machmillan', 'John Larrow');
INSERT INTO TEXT VALUES (102013121023, 'IOT: The Future', 'Jaico Books', 'Raman Singh');
INSERT INTO TEXT VALUES (102012383292, 'Embedded C Programming', 'Machmillan', 'Peatrice Burrow');
INSERT INTO TEXT VALUES (102010212332, 'Probability Basics', 'Penguin Publishers', 'Ramaswamy S');
INSERT INTO TEXT VALUES (100131211754, 'DBMS With Oracle SQL', 'Machmillan India', 'E Balagurusamy');
SELECT * FROM TEXT;
COMMIT;

INSERT INTO BOOK_ADOPTION VALUES (2122, 4, 100131211754);
INSERT INTO BOOK_ADOPTION VALUES (2122, 4, 100132112043);
INSERT INTO BOOK_ADOPTION VALUES (2123, 4, 100131212575);
INSERT INTO BOOK_ADOPTION VALUES (2123, 4, 102012383292);
INSERT INTO BOOK_ADOPTION VALUES (2124, 4, 100323121175);
INSERT INTO BOOK_ADOPTION VALUES (2125, 3, 100132112043);
INSERT INTO BOOK_ADOPTION VALUES (2126, 3, 102013121023);
SELECT * FROM BOOK_ADOPTION;
COMMIT;

INSERT INTO ENROLL VALUES ('220911123', 2122, 4, 100131211754);
INSERT INTO ENROLL VALUES ('220911456', 2123, 4, 100131212575);
INSERT INTO ENROLL VALUES ('220953321', 2125, 3, 100132112043);
INSERT INTO ENROLL VALUES ('220953234', 2126, 3, 102013121023);
INSERT INTO ENROLL VALUES ('220953234', 2123, 4, 100131212575);
INSERT INTO ENROLL VALUES ('220911789', 2122, 4, 100131211754);
INSERT INTO ENROLL VALUES ('220911789', 2123, 4, 102012383292);
INSERT INTO ENROLL VALUES ('220911789', 2123, 4, 102012383292);
SELECT * FROM ENROLL;
COMMIT;

SELECT * FROM STUDENT;
SELECT * FROM COURSE;
SELECT * FROM TEXT;
SELECT * FROM ENROLL;
SELECT * FROM BOOK_ADOPTION;


-- iii)
-- a)
SELECT CNAME AS COURSE_NAME FROM COURSE WHERE course# IN (
    SELECT course# FROM BOOK_ADOPTION
    GROUP BY COURSE#
    HAVING COUNT(*) > 1
);


-- b)
SELECT DISTINCT dept FROM course WHERE course# IN (
    SELECT DISTINCT course# FROM BOOK_ADOPTION WHERE book_isbn in (
        SELECT book_isbn FROM TEXT WHERE publisher='Machmillan'
    )
);


-- c)
WITH students_with_multiple_courses(reg) AS (
    SELECT regno FROM enroll
    GROUP BY regno
    HAVING COUNT(regno) > 1
),
students_dept_counts AS (
    SELECT reg, (
        SELECT COUNT(DISTINCT dept) FROM course
        WHERE course# IN (
            SELECT course# FROM enroll
            WHERE regno=reg
        )
    ) AS dept_count FROM students_with_multiple_courses
)
SELECT * FROM student
WHERE regno IN (
    SELECT reg FROM students_dept_counts
    WHERE dept_count > 1
);


-- d)
SELECT * FROM STUDENT WHERE regno NOT IN (SELECT regno FROM ENROLL);


-- e)
WITH publisher_match(matched_dept) AS (
    SELECT DISTINCT dept FROM course WHERE course# IN (
        SELECT course# FROM book_adoption WHERE book_isbn IN (
            SELECT book_isbn FROM text WHERE publisher = 'Machmillan'
        )
    )
)
SELECT DISTINCT matched_dept FROM text, publisher_match
WHERE (SELECT COUNT(book_isbn) FROM book_adoption
    WHERE course# IN (
        SELECT course# FROM course
        WHERE dept=matched_dept
    )
    AND (SELECT publisher FROM text WHERE book_isbn = book_adoption.book_isbn) <> 'Machmillan'
) = 0;


-- f)
SELECT booktitle, author, publisher FROM text
WHERE book_isbn IN (
    SELECT book_isbn FROM book_adoption
) AND book_isbn IN (
    SELECT book_isbn FROM enroll
);


-- g)
SELECT * FROM course WHERE course# IN (
    SELECT course# FROM book_adoption WHERE (
        SELECT COUNT(*) FROM text
        WHERE publisher = 'Machmillan'
            AND book_isbn IN (
                SELECT book_isbn FROM enroll WHERE course#=book_adoption.course#
            )
    ) >= 1
);


-- h)
SELECT * FROM STUDENT WHERE regno IN (
    SELECT regno FROM enroll
    GROUP BY regno
    ORDER BY COUNT(book_isbn) DESC
    FETCH FIRST 1 ROWS ONLY
);


-- i)
SELECT publisher, COUNT(book_isbn) FROM text GROUP BY publisher;


-- j)
SELECT * FROM STUDENT WHERE regno IN (
    SELECT regno FROM enroll
    WHERE book_isbn = ALL (
        SELECT book_isbn FROM book_adoption
        WHERE course#=enroll.course#
    ) GROUP BY regno
);
