CREATE TABLE nckh_login (
    id VARCHAR(20) PRIMARY KEY,
    users VARCHAR(20),
    pass VARCHAR(20),
    names VARCHAR(40),
    powerful VARCHAR(40)
);

CREATE TABLE nckh_students (
    id VARCHAR(20) PRIMARY KEY,
    names VARCHAR(40),
    birthday DATE,
    id_class VARCHAR(20),
    sex TINYINT,
    phone VARCHAR(10),
    email VARCHAR(255)
);

CREATE TABLE nckh_classes (
   id  VARCHAR (20) PRIMARY KEY,
   names  varchar (255)
);

CREATE TABLE nckh_teachers (
   id  varchar (20) PRIMARY KEY,
   name  varchar (40),
   birthday date ,
   address varchar (255),
   phone varchar (10), 
   email varchar (255)
);

CREATE TABLE nckh_reminder (
     id int PRIMARY KEY, 
     title varchar (255), 
     content text , 
     time date , 
     id_teacher varchar (20)
);

CREATE TABLE nckh_projects (
      id int PRIMARY KEY, 
      name  varchar (255), 
      topic_id int,  
      student_id int,  
      teacher_id int,  
      created_at date ,  
      endtime date
); 

CREATE TABLE nckh_topic(
       id INT NOT NULL PRIMARY KEY,
       name TEXT NOT NULL
); 

CREATE TABLE nckh_details(
       project_id INT NOT NULL PRIMARY KEY,
       progress_id INT NOT NULL,
       status TINYINT NOT NULL
); 

 CREATE TABLE nckh_progress(
        ID INT NOT NULL PRIMARY KEY,
        title TEXT NOT NULL ,
        comment TEXT NOT NULL ,
        start DATE NOT NULL ,
        ends DATE NOT NULL
);
