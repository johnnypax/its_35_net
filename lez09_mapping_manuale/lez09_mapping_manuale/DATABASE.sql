CREATE TABLE Videocassetta(
	videocassettaID INTEGER PRIMARY KEY IDENTITY(1,1),
	titolo VARCHAR(250) NOT NULL,
	genere VARCHAR(250) NOT NULL DEFAULT 'N.D.',
	regista VARCHAR(250),
	anno INTEGER,
	codice VARCHAR(250) NOT NULL UNIQUE
);

CREATE TABLE Utente(
	utenteID INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL UNIQUE
);

CREATE TABLE Prestito(
	data_prestito DATETIME DEFAULT CURRENT_TIMESTAMP,
	videocassettaRIF INTEGER NOT NULL,
	utenteRIF INTEGER NOT NULL,
	FOREIGN KEY (videocassettaRIF) REFERENCES Videocassetta(videocassettaID) ON DELETE CASCADE,
	FOREIGN KEY (utenteRIF) REFERENCES Utente(utenteID) ON DELETE CASCADE,
	PRIMARY KEY (videocassettaRIF, utenteRIF)
);

-- ============================================
-- INSERT Videocassetta (25 record)
-- ============================================
INSERT INTO Videocassetta (titolo, genere, regista, anno, codice) VALUES
('Il Padrino',               'Drammatico',  'Francis Ford Coppola', 1972, 'VHS-001'),
('Schindler''s List',        'Drammatico',  'Steven Spielberg',     1993, 'VHS-002'),
('Pulp Fiction',             'Thriller',    'Quentin Tarantino',    1994, 'VHS-003'),
('Jurassic Park',            'Avventura',   'Steven Spielberg',     1993, 'VHS-004'),
('Terminator 2',             'Azione',      'James Cameron',        1991, 'VHS-005'),
('Il Re Leone',              'Animazione',  'Roger Allers',         1994, 'VHS-006'),
('Forrest Gump',             'Drammatico',  'Robert Zemeckis',      1994, 'VHS-007'),
('Die Hard',                 'Azione',      'John McTiernan',       1988, 'VHS-008'),
('Matrix',                   'Fantascienza','Wachowski Sisters',    1999, 'VHS-009'),
('Titanic',                  'Romantico',   'James Cameron',        1997, 'VHS-010'),
('Braveheart',               'Storico',     'Mel Gibson',           1995, 'VHS-011'),
('Il Silenzio degli Innocenti','Thriller',  'Jonathan Demme',       1991, 'VHS-012'),
('Home Alone',               'Commedia',    'Chris Columbus',       1990, 'VHS-013'),
('Ghost',                    'Romantico',   'Jerry Zucker',         1990, 'VHS-014'),
('Aladdin',                  'Animazione',  'Ron Clements',         1992, 'VHS-015'),
('Il Gladiatore',            'Storico',     'Ridley Scott',         2000, 'VHS-016'),
('American Beauty',          'Drammatico',  'Sam Mendes',           1999, 'VHS-017'),
('Fight Club',               'Thriller',    'David Fincher',        1999, 'VHS-018'),
('Toy Story',                'Animazione',  'John Lasseter',        1995, 'VHS-019'),
('Speed',                    'Azione',      'Jan de Bont',          1994, 'VHS-020'),
('Pretty Woman',             'Romantico',   'Garry Marshall',       1990, 'VHS-021'),
('Misery',                   'Horror',      'Rob Reiner',           1990, 'VHS-022'),
('Scream',                   'Horror',      'Wes Craven',           1996, 'VHS-023'),
('La vita è bella',          'Drammatico',  'Roberto Benigni',      1997, 'VHS-024'),
('Nuovo Cinema Paradiso',    'Drammatico',  'Giuseppe Tornatore',   1988, 'VHS-025');


-- ============================================
-- INSERT Utente (20 record)
-- ============================================
INSERT INTO Utente (nome, cognome, email) VALUES
('Marco',     'Rossi',       'marco.rossi@email.it'),
('Laura',     'Bianchi',     'laura.bianchi@email.it'),
('Giovanni',  'Ferrari',     'giovanni.ferrari@email.it'),
('Sofia',     'Esposito',    'sofia.esposito@email.it'),
('Luca',      'Romano',      'luca.romano@email.it'),
('Giulia',    'Colombo',     'giulia.colombo@email.it'),
('Andrea',    'Ricci',       'andrea.ricci@email.it'),
('Chiara',    'Marino',      'chiara.marino@email.it'),
('Matteo',    'Greco',       'matteo.greco@email.it'),
('Valentina', 'Bruno',       'valentina.bruno@email.it'),
('Alessandro','Conti',       'alessandro.conti@email.it'),
('Francesca', 'De Luca',     'francesca.deluca@email.it'),
('Davide',    'Mancini',     'davide.mancini@email.it'),
('Elena',     'Costa',       'elena.costa@email.it'),
('Simone',    'Gallo',       'simone.gallo@email.it'),
('Alessia',   'Martini',     'alessia.martini@email.it'),
('Federico',  'Leone',       'federico.leone@email.it'),
('Martina',   'Serra',       'martina.serra@email.it'),
('Riccardo',  'Fontana',     'riccardo.fontana@email.it'),
('Paola',     'Barbieri',    'paola.barbieri@email.it');


-- ============================================
-- INSERT Prestito (25 record)
-- ============================================
INSERT INTO Prestito (videocassettaRIF, utenteRIF) VALUES
( 1,  1),
( 2,  2),
( 3,  3),
( 4,  4),
( 5,  5),
( 6,  6),
( 7,  7),
( 8,  8),
( 9,  9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15),
(16, 16),
(17, 17),
(18, 18),
(19, 19),
(20, 20),
(21,  1),
(22,  3),
(23,  5),
(24,  7),
(25,  9);

SELECT * FROM Utente;

SELECT * 
	FROM Videocassetta
	JOIN Prestito ON Videocassetta.videocassettaID = Prestito.videocassettaRIF
	JOIN Utente ON Prestito.utenteRIF = Utente.utenteID;