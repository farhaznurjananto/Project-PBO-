-- Database: hotelPBO

-- DROP DATABASE IF EXISTS "hotelPBO";

CREATE DATABASE "hotelPBO"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'English_Indonesia.1252'
    LC_CTYPE = 'English_Indonesia.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;
	
-- Table: public.admin

-- DROP TABLE IF EXISTS public.admin;

CREATE TABLE IF NOT EXISTS public.admin
(
    admin_id integer NOT NULL DEFAULT nextval('admin_admin_id_seq'::regclass),
    admin_username character varying(100) COLLATE pg_catalog."default" NOT NULL,
    admin_password character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT admin_pkey PRIMARY KEY (admin_id),
    CONSTRAINT admin_admin_username_key UNIQUE (admin_username)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.admin
    OWNER to postgres;
	
-- Table: public.customer

-- DROP TABLE IF EXISTS public.customer;

CREATE TABLE IF NOT EXISTS public.customer
(
    customer_id integer NOT NULL DEFAULT nextval('customer_customer_id_seq'::regclass),
    customer_fullname character varying(255) COLLATE pg_catalog."default" NOT NULL,
    customer_birthdate date NOT NULL,
    customer_phone character varying(20) COLLATE pg_catalog."default" NOT NULL,
    customer_state character varying(100) COLLATE pg_catalog."default" NOT NULL,
    customer_city character varying(100) COLLATE pg_catalog."default" NOT NULL,
    customer_address text COLLATE pg_catalog."default" NOT NULL,
    customer_email character varying(100) COLLATE pg_catalog."default" NOT NULL,
    customer_username character varying(100) COLLATE pg_catalog."default" NOT NULL,
    customer_password character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT customer_pkey PRIMARY KEY (customer_id),
    CONSTRAINT customer_customer_username_key UNIQUE (customer_username)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.customer
    OWNER to postgres;
	
-- Table: public.reservation

-- DROP TABLE IF EXISTS public.reservation;

CREATE TABLE IF NOT EXISTS public.reservation
(
    reservation_id integer NOT NULL DEFAULT nextval('reservation_reservation_id_seq'::regclass),
    reservation_date date NOT NULL DEFAULT CURRENT_DATE,
    reservation_checkin date NOT NULL,
    reservation_checkout date NOT NULL,
    id_admin integer NOT NULL DEFAULT 1,
    id_room integer NOT NULL,
    id_customer integer NOT NULL,
    reservation_status boolean DEFAULT false,
    CONSTRAINT reservation_pkey PRIMARY KEY (reservation_id),
    CONSTRAINT fk_admin FOREIGN KEY (id_admin)
        REFERENCES public.admin (admin_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_customer FOREIGN KEY (id_customer)
        REFERENCES public.customer (customer_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_room FOREIGN KEY (id_room)
        REFERENCES public.room (room_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.reservation
    OWNER to postgres;
	
-- Table: public.room

-- DROP TABLE IF EXISTS public.room;

CREATE TABLE IF NOT EXISTS public.room
(
    room_id integer NOT NULL DEFAULT nextval('room_room_id_seq'::regclass),
    room_number integer NOT NULL,
    room_status boolean NOT NULL DEFAULT true,
    id_room_type integer NOT NULL,
    CONSTRAINT room_pkey PRIMARY KEY (room_id),
    CONSTRAINT room_room_number_key UNIQUE (room_number),
    CONSTRAINT fk_room_type FOREIGN KEY (id_room_type)
        REFERENCES public.room_type (room_type_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.room
    OWNER to postgres;
	
-- Table: public.room_type

-- DROP TABLE IF EXISTS public.room_type;

CREATE TABLE IF NOT EXISTS public.room_type
(
    room_type_id integer NOT NULL DEFAULT nextval('room_type_room_type_id_seq'::regclass),
    room_type_name character varying(255) COLLATE pg_catalog."default" NOT NULL,
    room_type_price integer NOT NULL,
    room_type_description text COLLATE pg_catalog."default" NOT NULL,
    room_type_img character varying(255) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT room_type_pkey PRIMARY KEY (room_type_id),
    CONSTRAINT room_type_room_type_name_key UNIQUE (room_type_name)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.room_type
    OWNER to postgres;