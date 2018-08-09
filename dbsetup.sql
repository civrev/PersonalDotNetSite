--The Database I set up for my site

CREATE TABLE skills (
    Id int IDENTITY PRIMARY KEY,
    Name varchar(30) NOT NULL,
    ShortDescription text NOT NULL,
    LongDescription text NOT NULL,
	ImageThumbnailUrl text NOT NULL,
	ImageUrl text NOT NULL,
);

CREATE TABLE projects (
    Id int IDENTITY PRIMARY KEY,
    Name varchar(30) NOT NULL,
    ShortDescription text NOT NULL,
    LongDescription text NOT NULL,
	ImageThumbnailUrl text NOT NULL,
	ImageUrl text NOT NULL,
);

CREATE TABLE contact (
    Email varchar(30) PRIMARY KEY,
    AltEmail varchar(30) NOT NULL,
    GitHubLink varchar(30) NOT NULL,
	DockerLink varchar(30) NOT NULL,
	LinkedInLink varchar(30) NOT NULL,
	PhoneNumber varchar(30) NOT NULL,
);

CREATE TABLE faqs (
    Id int IDENTITY PRIMARY KEY,
    Question text NOT NULL,
    Answer text NOT NULL,
);

CREATE TABLE paragraphs (
    Id int IDENTITY PRIMARY KEY,
	Type varchar(30) NOT NULL,
    Text text NOT NULL
);


-- Inserts
INSERT INTO skills
        ( Name
        , ShortDescription
        , LongDescription
        , ImageThumbnailUrl
        , ImageUrl
        )
  VALUES
        ('skill title'
        ,'placeholder sdesc'
        ,'placeholder Ldesc'
        ,'placeholder iUrl'
        ,'placeholder thumbnailurl');
		
		
INSERT INTO projects
        ( Name
        , ShortDescription
        , LongDescription
        , ImageThumbnailUrl
        , ImageUrl
        )
  VALUES
        ('proj title'
        ,'placeholder sdesc'
        ,'placeholder Ldesc'
        ,'placeholder thumbnailurl'
        ,'placeholder iUrl');
		
		
INSERT INTO faqs
        ( Question, Answer)
  VALUES
        ('temp question', 'temp answer');
		
INSERT INTO contact
        ( Email
        , AltEmail
        , GitHubLink
        , DockerLink
        , LinkedInLink
		, PhoneNumber
        )
  VALUES
        ('cewatt6923@ung.edu'
        ,'temp alt email'
        ,'github link'
        ,'docker link'
        ,'linkedin link'
		,'phone # here');
		
ALTER TABLE contact ALTER COLUMN AltEmail varchar(90);
ALTER TABLE contact ALTER COLUMN GitHubLink varchar(90);
ALTER TABLE contact ALTER COLUMN DockerLink varchar(90);
ALTER TABLE contact ALTER COLUMN LinkedInLink varchar(90);


