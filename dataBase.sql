-- admin
CREATE TABLE admin (
	admin_id SERIAL PRIMARY KEY,
	admin_username VARCHAR(100) UNIQUE NOT NULL,
	admin_password VARCHAR(20) NOT NULL
);

INSERT INTO admin(admin_username, admin_password)
VALUES('admin', 'admin');

-- room type
CREATE TABLE room_type(
	room_type_id SERIAL PRIMARY KEY,
	room_type_name VARCHAR(255) UNIQUE NOT NULL,
	room_type_price INT NOT NULL,
	room_type_description TEXT NOT NULL,
	room_type_img VARCHAR(255) NOT NULL
);

-- room
CREATE TABLE room (
	room_id SERIAL PRIMARY KEY,
	room_number INT UNIQUE NOT NULL,
	room_status BOOL NOT NULL DEFAULT TRUE,
	id_room_type INT NOT NULL,
	CONSTRAINT fk_room_type
	FOREIGN KEY (id_room_type) REFERENCES room_type(room_type_id)
);


-- customer
CREATE TABLE customer (
	customer_id SERIAL PRIMARY KEY,
	customer_fullname VARCHAR(255) NOT NULL,
	customer_birthdate DATE NOT NULL,
	customer_phone VARCHAR(20) NOT NULL,
	customer_state VARCHAR(100) NOT NULL,
	customer_city VARCHAR(100) NOT NULL,
	customer_address TEXT NOT NULL,
	customer_email VARCHAR(100) NOT NULL,
	customer_username VARCHAR(100) UNIQUE NOT NULL,
	customer_password VARCHAR(20) NOT NULL
);

CREATE TABLE reservation(
	reservation_id SERIAL PRIMARY KEY,
	reservation_date DATE NOT NULL DEFAULT CURRENT_DATE,
	reservation_checkin DATE NOT NULL,
	reservation_checkout DATE NOT NULL,
	reservation_status BOOLEAN DEFAULT FALSE;
	id_admin INT NOT NULL DEFAULT 1,
	id_room INT NOT NULL,
	id_customer INT NOT NULL,
	CONSTRAINT fk_admin
	FOREIGN KEY (id_admin) REFERENCES admin(admin_id),
	CONSTRAINT fk_room
	FOREIGN KEY (id_room) REFERENCES room(room_id),
	CONSTRAINT fk_customer
	FOREIGN KEY (id_customer) REFERENCES customer(customer_id)
);