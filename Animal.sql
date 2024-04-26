CREATE TABLE Animal (
    IdAnimal int identity NOT NULL,
    Name nvarchar(100)  NOT NULL,
    Description nvarchar(200)  NULL,
    Category nvarchar(100)  NOT NULL,
    Area nvarchar(500)  NOT NULL,
    CONSTRAINT Animal_pk PRIMARY KEY (IdAnimal)
);

insert into Animal(Name, Description, Category, Area)
values('Giraffe', 'The giraffe is the tallest land animal, characterized by an exceptionally long neck and unique height. Their coat is spotted, aiding in camouflage on the savannah.',
'Mammal', 'Sub-Saharan Africa');
insert into Animal(Name, Description, Category, Area)
values('The African elephant', 'The African elephant is the largest land animal on Earth. They have distinctive large ears and a long trunk. African elephants are social and intelligent, living in family groups.',
'Mammal', 'Sub-Saharan Africa');
insert into Animal(Name, Description, Category, Area)
values('The whale shark', 'The whale shark is the largest living species of fish. It has a large, conical body and a hammerhead-shaped head. Whale sharks are filter feeders, and their sightings attract many tourists.',
'fish', 'Atlantic Ocean, Indian Ocean, Pacific Ocean');
insert into Animal(Name, Description, Category, Area)
values('The emperor penguin', 'The emperor penguin is a large species of penguin found in Antarctica. They have a distinctive black-and-white appearance with golden patches on their necks. Emperor penguins are impressive swimmers and known for their family-oriented behavior.',
'Bird', 'Antarctica');