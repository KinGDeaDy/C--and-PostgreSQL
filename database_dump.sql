--
-- PostgreSQL database dump
--

-- Dumped from database version 13.3
-- Dumped by pg_dump version 13.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: course_work; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA course_work;


ALTER SCHEMA course_work OWNER TO postgres;

--
-- Name: add_dp(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_dp(sid integer, lid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
            if exists(select subject_id,lector_id from subjects_lectors where subject_id=sID and lector_id=lID)
                then raise exception 'Данная связь уже существует';
            else
                INSERT INTO subjects_lectors (subject_id, lector_id) VALUES (sID,lID);
                end if;
        END
$$;


ALTER FUNCTION public.add_dp(sid integer, lid integer) OWNER TO postgres;

--
-- Name: add_group(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_group(c character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                INSERT INTO groups (cypher) VALUES (c);
        END
$$;


ALTER FUNCTION public.add_group(c character varying) OWNER TO postgres;

--
-- Name: add_lector(character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_lector(f_name character varying, l_name character varying, m_name character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                INSERT INTO lectors (name, surname, middle_name) VALUES (f_name,l_name,m_name);
        END
$$;


ALTER FUNCTION public.add_lector(f_name character varying, l_name character varying, m_name character varying) OWNER TO postgres;

--
-- Name: add_marks(integer, integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_marks(m integer, a_count integer, sid integer, dpid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
            IF exists(select * from  marks where student_id=sID AND subjects_lectors_id=dpID)
            then raise exception 'Данная оценка уже записана';
            else INSERT INTO marks (mark, absent_count, student_id, subjects_lectors_id) VALUES (m,a_count,sID,dpID);
            END IF;
        END
$$;


ALTER FUNCTION public.add_marks(m integer, a_count integer, sid integer, dpid integer) OWNER TO postgres;

--
-- Name: add_student(character varying, character varying, character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_student(f_name character varying, l_name character varying, m_name character varying, s_number integer, g_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                INSERT INTO students ( name, surname, middle_name, ticket_number, group_id) VALUES (f_name,l_name,m_name,s_number,g_id);
        END
$$;


ALTER FUNCTION public.add_student(f_name character varying, l_name character varying, m_name character varying, s_number integer, g_id integer) OWNER TO postgres;

--
-- Name: add_subject(character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_subject(s_name character varying, h_count integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                INSERT INTO subjects (name, hours_count) VALUES (s_name,h_count);
        END
$$;


ALTER FUNCTION public.add_subject(s_name character varying, h_count integer) OWNER TO postgres;

--
-- Name: delete_dp(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.delete_dp(dp_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
    begin
        DELETE FROM subjects_lectors WHERE subjects_lectors.id = dp_id;
    end
    $$;


ALTER FUNCTION public.delete_dp(dp_id integer) OWNER TO postgres;

--
-- Name: delete_group(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.delete_group(group_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
    begin
        DELETE FROM groups WHERE groups.id = group_id;
    end
    $$;


ALTER FUNCTION public.delete_group(group_id integer) OWNER TO postgres;

--
-- Name: delete_lector(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.delete_lector(lector_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
    begin
        DELETE FROM lectors WHERE lectors.id = lector_id;
    end
    $$;


ALTER FUNCTION public.delete_lector(lector_id integer) OWNER TO postgres;

--
-- Name: delete_mark(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.delete_mark(mark_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
    begin
        DELETE FROM marks WHERE marks.id = mark_id;
    end
    $$;


ALTER FUNCTION public.delete_mark(mark_id integer) OWNER TO postgres;

--
-- Name: delete_student(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.delete_student(student_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
    begin
        DELETE FROM students WHERE students.id = student_id;
    end
    $$;


ALTER FUNCTION public.delete_student(student_id integer) OWNER TO postgres;

--
-- Name: delete_subject(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.delete_subject(subject_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
    begin
        DELETE FROM subjects WHERE subjects.id = subject_id;
    end
    $$;


ALTER FUNCTION public.delete_subject(subject_id integer) OWNER TO postgres;

--
-- Name: drop_student(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.drop_student() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
    begin
        update groups set students_count = students_count - 1 where id=old.group_id;
        return new;
    end
    $$;


ALTER FUNCTION public.drop_student() OWNER TO postgres;

--
-- Name: five_count(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.five_count(id_s integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    declare i integer;
    declare five_count integer:=0;
        BEGIN
        for i in select id_m from vector()
        loop
            if((select mark from marks where id=i and student_id=id_s)=5)
                then five_count=five_count+1;
                end if;
        end loop;
        return five_count;
        END
$$;


ALTER FUNCTION public.five_count(id_s integer) OWNER TO postgres;

--
-- Name: k_updatesubject(integer, character varying, integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.k_updatesubject(s_id integer, s_name character varying, s_h_count integer)
    LANGUAGE plpgsql
    AS $$
    declare
        my_cursor CURSOR for select * from subjects;
        temp_id integer;
        tempName varchar(40);
        tempHours integer;
begin
open my_cursor;
loop
    fetch my_cursor into temp_id,tempName,tempHours;
    if not FOUND then exit; end if;
    if (temp_id=s_id) then
        update subjects set name=s_name,hours_count=s_h_count where current of my_cursor;
    end if;
end loop;
end;
    $$;


ALTER PROCEDURE public.k_updatesubject(s_id integer, s_name character varying, s_h_count integer) OWNER TO postgres;

--
-- Name: make_grant(); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.make_grant()
    LANGUAGE plpgsql
    AS $$
    declare i integer;
begin
for i in select id from students
loop
update grants set grant_summary = grant_summary - 4000;
update students set "grant" = "grant" + 4000 where id=i;
    end loop ;
    if ((select * from grants)<0)
     then rollback ;
     raise exception 'Недостаточно средств в стипендиальном фонде';
    else commit;
    end if;
    END
$$;


ALTER PROCEDURE public.make_grant() OWNER TO postgres;

--
-- Name: new_student(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.new_student() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
    begin
        update groups set students_count = students_count + 1 where id=new.group_id;
        return new;
    end
    $$;


ALTER FUNCTION public.new_student() OWNER TO postgres;

--
-- Name: studentsview_updateable(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.studentsview_updateable() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
   BEGIN
       UPDATE students SET name=new.name, surname=new.surname,
                           middle_name=new.middle_name,ticket_number=new.ticket_number,
                           group_id=(select groups.id from groups where groups.cypher=new.cypher),
                           "grant"=new."grant" where id=old.id;
       RETURN NEW;
    END;
$$;


ALTER FUNCTION public.studentsview_updateable() OWNER TO postgres;

--
-- Name: update_dp(integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_dp(dp_id integer, sid integer, lid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
             if exists(select subject_id,lector_id from subjects_lectors where subject_id=sID and lector_id=lID)
                then raise exception 'Данная связь уже существует';
            else
                update subjects_lectors set subject_id=sID, lector_id=lID where id=dp_id;
                end if;
        END
$$;


ALTER FUNCTION public.update_dp(dp_id integer, sid integer, lid integer) OWNER TO postgres;

--
-- Name: update_group(integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_group(g_id integer, c character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                update groups set cypher=c where id=g_id;
        END
$$;


ALTER FUNCTION public.update_group(g_id integer, c character varying) OWNER TO postgres;

--
-- Name: update_lector(integer, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_lector(l_id integer, f_name character varying, l_name character varying, m_name character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                update lectors set name=f_name,surname=l_name,middle_name=m_name where id=l_id;
        END
$$;


ALTER FUNCTION public.update_lector(l_id integer, f_name character varying, l_name character varying, m_name character varying) OWNER TO postgres;

--
-- Name: update_marks(integer, integer, integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_marks(m_id integer, m integer, a_count integer, sid integer, dpid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
            IF exists(select * from  marks where student_id=sID AND subjects_lectors_id=dpID)
            then raise exception 'Данная оценка уже записана';
            else    update marks set mark=m,absent_count=a_count, student_id=sID, subjects_lectors_id=dpID where id=m_id;
            end if;
        END
$$;


ALTER FUNCTION public.update_marks(m_id integer, m integer, a_count integer, sid integer, dpid integer) OWNER TO postgres;

--
-- Name: update_student(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_student() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
    begin
        update groups set students_count = students_count + 1 where id=new.group_id;
        update groups set students_count = students_count - 1 where id=old.group_id;
        return new;
    end
    $$;


ALTER FUNCTION public.update_student() OWNER TO postgres;

--
-- Name: update_student(integer, character varying, character varying, character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_student(s_id integer, f_name character varying, l_name character varying, m_name character varying, s_number integer, g_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                update students set name=f_name, surname=l_name,middle_name=m_name, ticket_number=s_number, group_id=g_id where s_id=id;
        END
$$;


ALTER FUNCTION public.update_student(s_id integer, f_name character varying, l_name character varying, m_name character varying, s_number integer, g_id integer) OWNER TO postgres;

--
-- Name: update_subject(integer, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_subject(s_id integer, s_name character varying, h_count integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
        BEGIN
                update subjects set name=s_name,hours_count=h_count where id=s_id;
        END
$$;


ALTER FUNCTION public.update_subject(s_id integer, s_name character varying, h_count integer) OWNER TO postgres;

--
-- Name: vector(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.vector() RETURNS TABLE(id_m integer)
    LANGUAGE plpgsql
    AS $$
        BEGIN
        return query select id from marks;
        END
$$;


ALTER FUNCTION public.vector() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: grants; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.grants (
    grant_summary integer
);


ALTER TABLE course_work.grants OWNER TO postgres;

--
-- Name: groups; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.groups (
    id integer NOT NULL,
    cypher character varying(20),
    students_count integer,
    grant_summary integer
);


ALTER TABLE course_work.groups OWNER TO postgres;

--
-- Name: groups_id_seq; Type: SEQUENCE; Schema: course_work; Owner: postgres
--

CREATE SEQUENCE course_work.groups_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE course_work.groups_id_seq OWNER TO postgres;

--
-- Name: groups_id_seq; Type: SEQUENCE OWNED BY; Schema: course_work; Owner: postgres
--

ALTER SEQUENCE course_work.groups_id_seq OWNED BY course_work.groups.id;


--
-- Name: lectors; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.lectors (
    id integer NOT NULL,
    name character varying(20),
    surname character varying(20),
    middle_name character varying(20)
);


ALTER TABLE course_work.lectors OWNER TO postgres;

--
-- Name: lectors_id_seq; Type: SEQUENCE; Schema: course_work; Owner: postgres
--

CREATE SEQUENCE course_work.lectors_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE course_work.lectors_id_seq OWNER TO postgres;

--
-- Name: lectors_id_seq; Type: SEQUENCE OWNED BY; Schema: course_work; Owner: postgres
--

ALTER SEQUENCE course_work.lectors_id_seq OWNED BY course_work.lectors.id;


--
-- Name: marks; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.marks (
    mark integer,
    id integer NOT NULL,
    absent_count integer,
    student_id integer,
    subjects_lectors_id integer
);


ALTER TABLE course_work.marks OWNER TO postgres;

--
-- Name: marks_id_seq; Type: SEQUENCE; Schema: course_work; Owner: postgres
--

CREATE SEQUENCE course_work.marks_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE course_work.marks_id_seq OWNER TO postgres;

--
-- Name: marks_id_seq; Type: SEQUENCE OWNED BY; Schema: course_work; Owner: postgres
--

ALTER SEQUENCE course_work.marks_id_seq OWNED BY course_work.marks.id;


--
-- Name: students; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.students (
    id integer NOT NULL,
    name character varying(20),
    surname character varying(20),
    middle_name character varying(20),
    ticket_number integer,
    group_id integer,
    "grant" integer
);


ALTER TABLE course_work.students OWNER TO postgres;

--
-- Name: students_id_seq; Type: SEQUENCE; Schema: course_work; Owner: postgres
--

CREATE SEQUENCE course_work.students_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE course_work.students_id_seq OWNER TO postgres;

--
-- Name: students_id_seq; Type: SEQUENCE OWNED BY; Schema: course_work; Owner: postgres
--

ALTER SEQUENCE course_work.students_id_seq OWNED BY course_work.students.id;


--
-- Name: subjects; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.subjects (
    id integer NOT NULL,
    name character varying(40),
    hours_count integer
);


ALTER TABLE course_work.subjects OWNER TO postgres;

--
-- Name: subjects_id_seq; Type: SEQUENCE; Schema: course_work; Owner: postgres
--

CREATE SEQUENCE course_work.subjects_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE course_work.subjects_id_seq OWNER TO postgres;

--
-- Name: subjects_id_seq; Type: SEQUENCE OWNED BY; Schema: course_work; Owner: postgres
--

ALTER SEQUENCE course_work.subjects_id_seq OWNED BY course_work.subjects.id;


--
-- Name: subjects_lectors; Type: TABLE; Schema: course_work; Owner: postgres
--

CREATE TABLE course_work.subjects_lectors (
    id integer NOT NULL,
    subject_id integer,
    lector_id integer
);


ALTER TABLE course_work.subjects_lectors OWNER TO postgres;

--
-- Name: subjects_lectors_id_seq; Type: SEQUENCE; Schema: course_work; Owner: postgres
--

CREATE SEQUENCE course_work.subjects_lectors_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE course_work.subjects_lectors_id_seq OWNER TO postgres;

--
-- Name: subjects_lectors_id_seq; Type: SEQUENCE OWNED BY; Schema: course_work; Owner: postgres
--

ALTER SEQUENCE course_work.subjects_lectors_id_seq OWNED BY course_work.subjects_lectors.id;


--
-- Name: lectors; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.lectors (
    id integer NOT NULL,
    name character varying(20) NOT NULL,
    surname character varying(20) NOT NULL,
    middle_name character varying(20) NOT NULL
);


ALTER TABLE public.lectors OWNER TO postgres;

--
-- Name: subjects; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.subjects (
    id integer NOT NULL,
    name character varying(40) NOT NULL,
    hours_count integer NOT NULL
);


ALTER TABLE public.subjects OWNER TO postgres;

--
-- Name: subjects_lectors; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.subjects_lectors (
    id integer NOT NULL,
    subject_id integer NOT NULL,
    lector_id integer NOT NULL
);


ALTER TABLE public.subjects_lectors OWNER TO postgres;

--
-- Name: dpview; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.dpview AS
 SELECT subjects_lectors.id,
    l.name,
    l.surname,
    l.middle_name,
    s.name AS subject
   FROM ((public.subjects_lectors
     JOIN public.lectors l ON ((l.id = subjects_lectors.lector_id)))
     JOIN public.subjects s ON ((s.id = subjects_lectors.subject_id)));


ALTER TABLE public.dpview OWNER TO postgres;

--
-- Name: grants; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.grants (
    grant_summary integer NOT NULL
);


ALTER TABLE public.grants OWNER TO postgres;

--
-- Name: groups; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.groups (
    id integer NOT NULL,
    cypher character varying(20) NOT NULL,
    students_count integer DEFAULT 0 NOT NULL
);


ALTER TABLE public.groups OWNER TO postgres;

--
-- Name: groups_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.groups_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.groups_id_seq OWNER TO postgres;

--
-- Name: groups_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.groups_id_seq OWNED BY public.groups.id;


--
-- Name: lectors_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.lectors_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.lectors_id_seq OWNER TO postgres;

--
-- Name: lectors_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.lectors_id_seq OWNED BY public.lectors.id;


--
-- Name: marks; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.marks (
    mark integer NOT NULL,
    id integer NOT NULL,
    absent_count integer NOT NULL,
    student_id integer NOT NULL,
    subjects_lectors_id integer NOT NULL
);


ALTER TABLE public.marks OWNER TO postgres;

--
-- Name: marks_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.marks_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.marks_id_seq OWNER TO postgres;

--
-- Name: marks_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.marks_id_seq OWNED BY public.marks.id;


--
-- Name: marks_student_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.marks_student_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.marks_student_id_seq OWNER TO postgres;

--
-- Name: marks_student_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.marks_student_id_seq OWNED BY public.marks.student_id;


--
-- Name: students; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.students (
    id integer NOT NULL,
    name character varying(20) NOT NULL,
    surname character varying(20) NOT NULL,
    middle_name character varying(20) NOT NULL,
    ticket_number integer NOT NULL,
    group_id integer NOT NULL,
    "grant" integer DEFAULT 4000 NOT NULL
);


ALTER TABLE public.students OWNER TO postgres;

--
-- Name: marksview; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.marksview AS
 SELECT marks.id,
    marks.mark,
    marks.absent_count,
    (((st.surname)::text || ' '::text) || (st.name)::text) AS student,
    s.name AS subject,
    (((l.surname)::text || ' '::text) || (l.name)::text) AS lector
   FROM ((((public.marks
     JOIN public.students st ON ((st.id = marks.student_id)))
     JOIN public.subjects_lectors sl ON ((sl.id = marks.subjects_lectors_id)))
     JOIN public.lectors l ON ((l.id = sl.lector_id)))
     JOIN public.subjects s ON ((s.id = sl.subject_id)));


ALTER TABLE public.marksview OWNER TO postgres;

--
-- Name: students_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.students_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.students_id_seq OWNER TO postgres;

--
-- Name: students_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.students_id_seq OWNED BY public.students.id;


--
-- Name: studentsview; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.studentsview AS
 SELECT students.id,
    students.name,
    students.surname,
    students.middle_name,
    students.ticket_number,
    "G".cypher,
    students."grant"
   FROM (public.students
     JOIN public.groups "G" ON (("G".id = students.group_id)));


ALTER TABLE public.studentsview OWNER TO postgres;

--
-- Name: subjects_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.subjects_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.subjects_id_seq OWNER TO postgres;

--
-- Name: subjects_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.subjects_id_seq OWNED BY public.subjects.id;


--
-- Name: subjects_lectors_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.subjects_lectors_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.subjects_lectors_id_seq OWNER TO postgres;

--
-- Name: subjects_lectors_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.subjects_lectors_id_seq OWNED BY public.subjects_lectors.id;


--
-- Name: groups id; Type: DEFAULT; Schema: course_work; Owner: postgres
--

ALTER TABLE ONLY course_work.groups ALTER COLUMN id SET DEFAULT nextval('course_work.groups_id_seq'::regclass);


--
-- Name: lectors id; Type: DEFAULT; Schema: course_work; Owner: postgres
--

ALTER TABLE ONLY course_work.lectors ALTER COLUMN id SET DEFAULT nextval('course_work.lectors_id_seq'::regclass);


--
-- Name: marks id; Type: DEFAULT; Schema: course_work; Owner: postgres
--

ALTER TABLE ONLY course_work.marks ALTER COLUMN id SET DEFAULT nextval('course_work.marks_id_seq'::regclass);


--
-- Name: students id; Type: DEFAULT; Schema: course_work; Owner: postgres
--

ALTER TABLE ONLY course_work.students ALTER COLUMN id SET DEFAULT nextval('course_work.students_id_seq'::regclass);


--
-- Name: subjects id; Type: DEFAULT; Schema: course_work; Owner: postgres
--

ALTER TABLE ONLY course_work.subjects ALTER COLUMN id SET DEFAULT nextval('course_work.subjects_id_seq'::regclass);


--
-- Name: subjects_lectors id; Type: DEFAULT; Schema: course_work; Owner: postgres
--

ALTER TABLE ONLY course_work.subjects_lectors ALTER COLUMN id SET DEFAULT nextval('course_work.subjects_lectors_id_seq'::regclass);


--
-- Name: groups id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups ALTER COLUMN id SET DEFAULT nextval('public.groups_id_seq'::regclass);


--
-- Name: lectors id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lectors ALTER COLUMN id SET DEFAULT nextval('public.lectors_id_seq'::regclass);


--
-- Name: marks id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marks ALTER COLUMN id SET DEFAULT nextval('public.marks_id_seq'::regclass);


--
-- Name: marks student_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marks ALTER COLUMN student_id SET DEFAULT nextval('public.marks_student_id_seq'::regclass);


--
-- Name: students id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students ALTER COLUMN id SET DEFAULT nextval('public.students_id_seq'::regclass);


--
-- Name: subjects id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subjects ALTER COLUMN id SET DEFAULT nextval('public.subjects_id_seq'::regclass);


--
-- Name: subjects_lectors id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subjects_lectors ALTER COLUMN id SET DEFAULT nextval('public.subjects_lectors_id_seq'::regclass);


--
-- Data for Name: grants; Type: TABLE DATA; Schema: course_work; Owner: postgres
--

INSERT INTO course_work.grants VALUES (-80000);


--
-- Data for Name: groups; Type: TABLE DATA; Schema: course_work; Owner: postgres
--

INSERT INTO course_work.groups VALUES (15, 'ИТ-20', 2, 25000);
INSERT INTO course_work.groups VALUES (16, 'ИТ-21', 4, 25000);
INSERT INTO course_work.groups VALUES (17, 'ИТ-19', 1, 25000);


--
-- Data for Name: lectors; Type: TABLE DATA; Schema: course_work; Owner: postgres
--

INSERT INTO course_work.lectors VALUES (1, 'Виталий', 'Большаков', 'Арсеньевич');
INSERT INTO course_work.lectors VALUES (2, 'Михаил', 'Коновалов', 'Дмитриевич');
INSERT INTO course_work.lectors VALUES (3, 'Василий', 'Блинов', 'Глебович');
INSERT INTO course_work.lectors VALUES (4, 'Волков', 'Аполлон', 'Данилович');
INSERT INTO course_work.lectors VALUES (5, 'Захар', 'Максимов', 'Богуславович');
INSERT INTO course_work.lectors VALUES (6, 'Василий', 'Романов', 'Романович');
INSERT INTO course_work.lectors VALUES (8, 'Михаил', 'Зеленин', 'Кириллович');


--
-- Data for Name: marks; Type: TABLE DATA; Schema: course_work; Owner: postgres
--



--
-- Data for Name: students; Type: TABLE DATA; Schema: course_work; Owner: postgres
--

INSERT INTO course_work.students VALUES (43, 'Арнольд', 'Молчанов', 'Сергеевич', 142, 16, 20000);
INSERT INTO course_work.students VALUES (42, 'Петр', 'Петров', 'Петрович', 141, 16, 20000);
INSERT INTO course_work.students VALUES (41, 'Иван', 'Иванов', 'Иванович', 140, 15, 20000);
INSERT INTO course_work.students VALUES (48, 'Эльмира', 'Лукина', 'Владиславовна', 146, 16, 20000);
INSERT INTO course_work.students VALUES (44, 'Мстислав', 'Уваров', 'Кириллович', 143, 15, 20000);
INSERT INTO course_work.students VALUES (47, 'Анастасия', 'Пахомова', 'Семёновна', 145, 16, 20000);
INSERT INTO course_work.students VALUES (46, 'Сергей', 'Куликов', 'Русланович', 144, 17, 20000);


--
-- Data for Name: subjects; Type: TABLE DATA; Schema: course_work; Owner: postgres
--

INSERT INTO course_work.subjects VALUES (8, 'Право', 40);
INSERT INTO course_work.subjects VALUES (4, 'Иностранный язык', 80);
INSERT INTO course_work.subjects VALUES (7, 'Экономика', 40);
INSERT INTO course_work.subjects VALUES (3, 'Физкультура', 100);
INSERT INTO course_work.subjects VALUES (1, 'Математический анализ', 120);
INSERT INTO course_work.subjects VALUES (6, 'История', 150);
INSERT INTO course_work.subjects VALUES (5, 'Физика', 150);
INSERT INTO course_work.subjects VALUES (2, 'Алгебра', 100);
INSERT INTO course_work.subjects VALUES (11, 'Философия', 140);


--
-- Data for Name: subjects_lectors; Type: TABLE DATA; Schema: course_work; Owner: postgres
--

INSERT INTO course_work.subjects_lectors VALUES (8, 8, 1);
INSERT INTO course_work.subjects_lectors VALUES (6, 6, 2);
INSERT INTO course_work.subjects_lectors VALUES (2, 2, 4);
INSERT INTO course_work.subjects_lectors VALUES (1, 1, 5);
INSERT INTO course_work.subjects_lectors VALUES (5, 5, 3);
INSERT INTO course_work.subjects_lectors VALUES (12, 7, 1);
INSERT INTO course_work.subjects_lectors VALUES (13, 7, 2);
INSERT INTO course_work.subjects_lectors VALUES (14, 8, 2);
INSERT INTO course_work.subjects_lectors VALUES (15, 4, 4);
INSERT INTO course_work.subjects_lectors VALUES (16, 5, 4);
INSERT INTO course_work.subjects_lectors VALUES (17, 5, 2);
INSERT INTO course_work.subjects_lectors VALUES (18, 11, 3);
INSERT INTO course_work.subjects_lectors VALUES (19, 6, 3);
INSERT INTO course_work.subjects_lectors VALUES (4, 4, 3);


--
-- Data for Name: grants; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.grants VALUES (100000);


--
-- Data for Name: groups; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.groups VALUES (17, 'ИТ-19', 2);
INSERT INTO public.groups VALUES (15, 'ИТ-20', 2);
INSERT INTO public.groups VALUES (16, 'ИТ-21', 4);


--
-- Data for Name: lectors; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.lectors VALUES (1, 'Виталий', 'Большаков', 'Арсеньевич');
INSERT INTO public.lectors VALUES (2, 'Михаил', 'Коновалов', 'Дмитриевич');
INSERT INTO public.lectors VALUES (3, 'Василий', 'Блинов', 'Глебович');
INSERT INTO public.lectors VALUES (4, 'Волков', 'Аполлон', 'Данилович');
INSERT INTO public.lectors VALUES (5, 'Захар', 'Максимов', 'Богуславович');
INSERT INTO public.lectors VALUES (6, 'Василий', 'Романов', 'Романович');
INSERT INTO public.lectors VALUES (7, 'Михаил', 'Зеленин', 'Кириллович');
INSERT INTO public.lectors VALUES (8, 'Николай', 'Прокофьев', 'Сергеевич');


--
-- Data for Name: marks; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.marks VALUES (5, 13, 0, 42, 7);
INSERT INTO public.marks VALUES (5, 14, 0, 42, 8);
INSERT INTO public.marks VALUES (5, 15, 0, 42, 11);
INSERT INTO public.marks VALUES (5, 16, 3, 42, 17);
INSERT INTO public.marks VALUES (4, 17, 3, 41, 7);
INSERT INTO public.marks VALUES (4, 18, 2, 41, 10);
INSERT INTO public.marks VALUES (4, 19, 2, 41, 13);
INSERT INTO public.marks VALUES (4, 20, 3, 41, 15);
INSERT INTO public.marks VALUES (5, 21, 2, 48, 8);
INSERT INTO public.marks VALUES (5, 22, 4, 48, 11);
INSERT INTO public.marks VALUES (4, 23, 2, 48, 15);
INSERT INTO public.marks VALUES (4, 24, 21, 48, 16);
INSERT INTO public.marks VALUES (3, 25, 20, 44, 7);
INSERT INTO public.marks VALUES (3, 26, 2, 44, 12);
INSERT INTO public.marks VALUES (3, 27, 23, 44, 16);
INSERT INTO public.marks VALUES (3, 28, 23, 44, 9);
INSERT INTO public.marks VALUES (4, 29, 21, 47, 9);
INSERT INTO public.marks VALUES (4, 30, 2, 47, 12);
INSERT INTO public.marks VALUES (3, 31, 30, 47, 13);
INSERT INTO public.marks VALUES (3, 32, 2, 47, 11);
INSERT INTO public.marks VALUES (3, 33, 40, 46, 11);
INSERT INTO public.marks VALUES (3, 34, 43, 46, 13);
INSERT INTO public.marks VALUES (2, 35, 12, 46, 8);
INSERT INTO public.marks VALUES (2, 36, 45, 46, 15);
INSERT INTO public.marks VALUES (4, 37, 23, 43, 8);
INSERT INTO public.marks VALUES (4, 38, 12, 43, 10);
INSERT INTO public.marks VALUES (3, 39, 24, 43, 9);
INSERT INTO public.marks VALUES (5, 40, 43, 43, 16);
INSERT INTO public.marks VALUES (4, 41, 45, 4, 8);
INSERT INTO public.marks VALUES (3, 42, 45, 4, 7);
INSERT INTO public.marks VALUES (2, 43, 21, 4, 13);
INSERT INTO public.marks VALUES (2, 44, 23, 4, 12);


--
-- Data for Name: students; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.students VALUES (4, 'Алексей', 'Петров', 'Николаевич', 148, 17, 20000);
INSERT INTO public.students VALUES (42, 'Петр', 'Петров', 'Петрович', 141, 16, 24000);
INSERT INTO public.students VALUES (41, 'Иван', 'Иванов', 'Иванович', 140, 15, 24000);
INSERT INTO public.students VALUES (48, 'Эльмира', 'Лукина', 'Владиславовна', 146, 16, 24000);
INSERT INTO public.students VALUES (44, 'Мстислав', 'Уваров', 'Кириллович', 143, 15, 24000);
INSERT INTO public.students VALUES (47, 'Анастасия', 'Пахомова', 'Семёновна', 145, 16, 24000);
INSERT INTO public.students VALUES (46, 'Сергей', 'Куликов', 'Русланович', 144, 17, 24000);
INSERT INTO public.students VALUES (43, 'Александр', 'Смирнов', 'Валерьевич', 147, 16, 24000);


--
-- Data for Name: subjects; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.subjects VALUES (14, 'Алгебра', 100);
INSERT INTO public.subjects VALUES (15, 'Иностранный язык', 80);
INSERT INTO public.subjects VALUES (16, 'Физика', 150);
INSERT INTO public.subjects VALUES (17, 'История', 150);
INSERT INTO public.subjects VALUES (18, 'Экономика', 40);
INSERT INTO public.subjects VALUES (19, 'Право', 40);
INSERT INTO public.subjects VALUES (20, 'Философия', 140);
INSERT INTO public.subjects VALUES (21, 'Физкультура', 40);
INSERT INTO public.subjects VALUES (13, 'Программирование', 40);


--
-- Data for Name: subjects_lectors; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.subjects_lectors VALUES (7, 13, 1);
INSERT INTO public.subjects_lectors VALUES (8, 14, 1);
INSERT INTO public.subjects_lectors VALUES (9, 15, 2);
INSERT INTO public.subjects_lectors VALUES (10, 16, 3);
INSERT INTO public.subjects_lectors VALUES (11, 16, 4);
INSERT INTO public.subjects_lectors VALUES (12, 17, 5);
INSERT INTO public.subjects_lectors VALUES (13, 18, 5);
INSERT INTO public.subjects_lectors VALUES (15, 19, 6);
INSERT INTO public.subjects_lectors VALUES (16, 20, 7);
INSERT INTO public.subjects_lectors VALUES (17, 21, 8);


--
-- Name: groups_id_seq; Type: SEQUENCE SET; Schema: course_work; Owner: postgres
--

SELECT pg_catalog.setval('course_work.groups_id_seq', 1, false);


--
-- Name: lectors_id_seq; Type: SEQUENCE SET; Schema: course_work; Owner: postgres
--

SELECT pg_catalog.setval('course_work.lectors_id_seq', 1, false);


--
-- Name: marks_id_seq; Type: SEQUENCE SET; Schema: course_work; Owner: postgres
--

SELECT pg_catalog.setval('course_work.marks_id_seq', 1, false);


--
-- Name: students_id_seq; Type: SEQUENCE SET; Schema: course_work; Owner: postgres
--

SELECT pg_catalog.setval('course_work.students_id_seq', 1, false);


--
-- Name: subjects_id_seq; Type: SEQUENCE SET; Schema: course_work; Owner: postgres
--

SELECT pg_catalog.setval('course_work.subjects_id_seq', 1, false);


--
-- Name: subjects_lectors_id_seq; Type: SEQUENCE SET; Schema: course_work; Owner: postgres
--

SELECT pg_catalog.setval('course_work.subjects_lectors_id_seq', 1, false);


--
-- Name: groups_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.groups_id_seq', 2, true);


--
-- Name: lectors_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.lectors_id_seq', 13, true);


--
-- Name: marks_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.marks_id_seq', 46, true);


--
-- Name: marks_student_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.marks_student_id_seq', 1, false);


--
-- Name: students_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.students_id_seq', 9, true);


--
-- Name: subjects_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.subjects_id_seq', 24, true);


--
-- Name: subjects_lectors_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.subjects_lectors_id_seq', 19, true);


--
-- Name: groups groups_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT groups_pk PRIMARY KEY (id);


--
-- Name: lectors lectors_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lectors
    ADD CONSTRAINT lectors_pk PRIMARY KEY (id);


--
-- Name: marks marks_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marks
    ADD CONSTRAINT marks_pk PRIMARY KEY (id);


--
-- Name: students students_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pk PRIMARY KEY (id);


--
-- Name: subjects_lectors subjects_lectors_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subjects_lectors
    ADD CONSTRAINT subjects_lectors_pk PRIMARY KEY (id);


--
-- Name: subjects subjects_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subjects
    ADD CONSTRAINT subjects_pk PRIMARY KEY (id);


--
-- Name: groups_cypher_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX groups_cypher_uindex ON public.groups USING btree (cypher);


--
-- Name: groups_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX groups_id_uindex ON public.groups USING btree (id);


--
-- Name: lectors_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX lectors_id_uindex ON public.lectors USING btree (id);


--
-- Name: marks_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX marks_id_uindex ON public.marks USING btree (id);


--
-- Name: students_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX students_id_uindex ON public.students USING btree (id);


--
-- Name: studets_ticket_number_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX studets_ticket_number_uindex ON public.students USING btree (ticket_number);


--
-- Name: subjects_lectors_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX subjects_lectors_id_uindex ON public.subjects_lectors USING btree (id);


--
-- Name: subjects_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX subjects_name_uindex ON public.subjects USING btree (name);


--
-- Name: studentsview studentsview_updateable_trig; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER studentsview_updateable_trig INSTEAD OF UPDATE ON public.studentsview FOR EACH ROW EXECUTE FUNCTION public.studentsview_updateable();


--
-- Name: students tr_drop_student; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER tr_drop_student AFTER DELETE ON public.students FOR EACH ROW EXECUTE FUNCTION public.drop_student();


--
-- Name: students tr_new_student; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER tr_new_student AFTER INSERT ON public.students FOR EACH ROW EXECUTE FUNCTION public.new_student();


--
-- Name: students tr_update_student; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER tr_update_student AFTER UPDATE ON public.students FOR EACH ROW EXECUTE FUNCTION public.update_student();


--
-- Name: marks marks_students_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marks
    ADD CONSTRAINT marks_students_id_fk FOREIGN KEY (student_id) REFERENCES public.students(id) ON DELETE CASCADE;


--
-- Name: marks marks_subjects_lectors_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marks
    ADD CONSTRAINT marks_subjects_lectors_id_fk FOREIGN KEY (subjects_lectors_id) REFERENCES public.subjects_lectors(id) ON DELETE CASCADE;


--
-- Name: students students_groups_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_groups_id_fk FOREIGN KEY (group_id) REFERENCES public.groups(id) ON DELETE CASCADE;


--
-- Name: subjects_lectors subjects_lectors_lectors_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subjects_lectors
    ADD CONSTRAINT subjects_lectors_lectors_id_fk FOREIGN KEY (lector_id) REFERENCES public.lectors(id) ON DELETE CASCADE;


--
-- Name: subjects_lectors subjects_lectors_subjects_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.subjects_lectors
    ADD CONSTRAINT subjects_lectors_subjects_id_fk FOREIGN KEY (subject_id) REFERENCES public.subjects(id) ON DELETE RESTRICT;


--
-- Name: TABLE lectors; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.lectors TO "User";


--
-- Name: TABLE subjects; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.subjects TO "User";


--
-- Name: TABLE subjects_lectors; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.subjects_lectors TO "User";


--
-- Name: TABLE dpview; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.dpview TO "User";


--
-- Name: TABLE grants; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.grants TO "User";


--
-- Name: TABLE groups; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.groups TO "User";


--
-- Name: TABLE marks; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.marks TO "User";


--
-- Name: TABLE students; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.students TO "User";


--
-- Name: TABLE marksview; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.marksview TO "User";


--
-- Name: TABLE studentsview; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.studentsview TO "User";


--
-- PostgreSQL database dump complete
--

