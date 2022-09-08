INSERT INTO Brand(BName) VALUES
('Kia'),
('Volvo'),
('Nissan'),
('Opel'),
('Hyundai'),
('Mazda'),
('Citroën'),
('Fiat'),
('Porsche'),
('Audi'),
('Tesla'),
('BMW'),
('Peugeot'),
('MINI')

INSERT INTO Model(MName) VALUES
('Ceed'),
('V60'),
('Qashqai'),
('Corsa'),
('Kona'),
('CX-3'),
('C1'),
('500'),
('Taycan 4'),
('500e'),
('e-tron'),
('C40'),
('Model 3'),
('iX'),
('e-208'),
('Cooper SE')

INSERT INTO FuelType(FuelName) VALUES
('El'),
('Benzin')

INSERT INTO Car(Variant, ReleaseYear, FuelUsagePerKM, Price, MName, BName, FuelName) VALUES
('1.0 T-GDI Benzin 120HK 5d', '2017-09-01', 19.2, 228501, 'Ceed', 'Kia', 'Benzin'),
('2,0 T Summun aut. 5d', '2011-09-01', 12.0, 621000, 'V60', 'Volvo', 'Benzin'),
('1,2 Dig-T 115 Tekna+ 5d', '2018-09-01', 17.9, 305990, 'Qashqai', 'Nissan', 'Benzin'),
('1,2 T 100 Sport aut. 5d', '2021-09-01', 22.4, 245811, 'Corsa', 'Opel', 'Benzin'),
('1,0 T-GDI  Nordic Edition+ 5d', '2019-09-01', 20.0, 206017, 'Kona', 'Hyundai', 'Benzin'),
('2,0 SkyActiv-G 121 Vision 5d', '2018-09-01', 16.9, 222495, 'CX-3', 'Mazda', 'Benzin'),
('1,0 VTI 72 SportLine 5d', '2018-09-01', 28.9, 92900, 'C1', 'Citroën', 'Benzin'),
('0,9 TwinAlr 80 Popstar 3d', '2017-09-01', 26.3, 147904, '500', 'Fiat', 'Benzin'),
('Cross Turismo 5d', '2021-09-01', 224.0, 895720, 'Taycan 4', 'Porsche', 'El'),
('La Prima 3d', '2021-09-01', 144.0, 263810, '500e', 'Fiat', 'El'),
('55 Prestige quattro 5d', '2020-09-01', 228.0, 737430, 'e-tron', 'Audi', 'El'),
('P8 ReCharge Ultimate 5d', '2022-09-01', 238.0, 475900, 'C40', 'Volvo', 'El'),
('RWD 4d', '2022-09-01', 144.0, 420810, 'Model 3', 'Tesla', 'El'),
('xDrive40 Fully Charged 5d', '2022-09-01', 194.0, 745820, 'iX', 'BMW', 'El'),
('50 Allure 5d', '2020-09-01', 164.0, 245910, 'e-208', 'Peugeot', 'El'),
('Experience 3d', '2020-09-01', 148.0, 280420, 'Cooper SE', 'MINI', 'El')

INSERT INTO FuelPrice(FuelName, Date, Price) VALUES
('Benzin', '2022-08-31', 16.36),
('Benzin', '2022-07-31', 17.19),
('Benzin', '2022-06-30', 18.69),
('Benzin', '2022-05-31', 18.69),
('El', '2022-08-31', 3.37),
('El', '2022-07-31', 1.89),
('El', '2022-06-30', 1.59),
('El', '2022-05-31', 1.24)