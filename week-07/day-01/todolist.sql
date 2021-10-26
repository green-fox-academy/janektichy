create database todo;
use todo;
CREATE TABLE todolist (
  id int PRIMARY KEY,
  task text,
  state bool
);
INSERT INTO todolist (id, task, state) VALUES (1, "Buy milk", false), (2, "go shopping", false), (3, "Go shit", false);
select * from todolist where state = true;
update todolist 
set state = true
where task like "Buy%";
select * from todolist;