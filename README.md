﻿# Markdown File

1.Задание 
		Создать следующие классы: 
			человек, 
			ученик, 
			ученик–раздолбай, 
			учитель, 
			директор. 

			Каждый человек имеет: 
			фамилию, 
			имя, 
			отчество, 
			год рождения. 
		
			Наследование определено в соответствии со здравым смыслом (ученик–раздолбай — наследник ученика). 
		
			Все сущности имеют методы: 
			1 Посчитать возраст (getAges). 
			2 обратиться по имени (getName) по правилу: учитель и директор — имя + отчество, 
			  ученик — имя, ученик-раздолбай — “Бяка” + имя. 
			3 булевский метод главный (head?): для директора возвращается истина, для остальных — ложь. 
			ФИО и год рождения должно задаваться в конструкторе. 
			После реализации создать экземпляры каждого класса и вызвать для них методы 
			getName, 
			getAges, 
			head?.
############################################################################################################
2.Задание 
 		Класс Phone.
			Создайте класс Phone, который содержит переменные 
			number, 
			model,
			weight

			Создайте три экземпляра этого класса. 
			Выведите на консоль значения их переменных. 
			Добавить в класс Phone методы: 
			receiveCall, имеет один параметр – имя звонящего. 
			Выводит на консоль сообщение 
			“Звонит {name}”. Метод getNumber – возвращает номер телефона. 
			Вызвать эти методы для каждого из объектов.
			Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и weight. 
			Добавить конструктор, который принимает на вход два параметра для инициализации переменных класса - number, model. 
			Добавить конструктор без параметров.
			Вызвать из конструктора с тремя параметрами конструктор с двумя. 
			Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. 
			Вызвать этот метод.
			Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.
############################################################################################################
3.Задание 
		Класс Person
			Создать класс Person, который содержит: 

			переменные:
			fullName, 
			age;

			методы:
			move(),
			talk(), в которых просто вывести на консоль сообщение -"Такой-то  Person говорит". 
			Добавьте два конструктора:
			Person(),
			Person(fullName, age).
			Создайте два объекта этого класса. Один объект инициализируется конструктором Person(), 
			другой - Person(fullName, age).
			Вызовите методы move() и talk().
############################################################################################################
4.Задание 
		Создать класс "Матрица". 
		
		Класс должен иметь следующие переменные:

		двумерный массив вещественных чисел;
		количество строк и столбцов в матрице.

		Класс должен иметь следующие методы:

		сложение с другой матрицей;
		умножение на число;
		вывод на печать; 
		умножение матриц.
############################################################################################################
5.Задание 
		Читатели библиотеки
		Определить класс Reader, хранящий такую информацию о пользователе библиотеки:

		ФИО,
		номер читательского билета,
		факультет,
		дата рождения,
		телефон.

		Методы 
		takeBook(), 
		returnBook().
		Разработать программу, в которой создается массив объектов данного класса.
		Перегрузить методы takeBook(), returnBook():
		- takeBook, который будет принимать количество взятых книг. Выводит на консоль сообщение "Петров В. В. взял 3 книги".
		- takeBook, который будет принимать переменное количество названий книг. Выводит на консоль сообщение "Петров В. В. взял книги: Приключения, Словарь, Энциклопедия".
		- takeBook, который будет принимать переменное количество объектов класса Book (создать новый класс, содержащий имя и автора книги). Выводит на консоль сообщение "Петров В. В. взял книги: Приключения, Словарь, Энциклопедия".
		 Аналогичным образом перегрузить метод returnBook(). Выводит на консоль сообщение "Петров В. В. вернул книги: Приключения, Словарь, Энциклопедия". Или  "Петров В. В. вернул 3 книги".
############################################################################################################
6.Задание 
		Student, Aspirant
		Hеализуйте класс Student и класс Aspirant, 
		аспирант отличается от студента наличием некой научной работы.
		Класс Student содержит переменные: 
		firstName, 
		lastName, 
		group,
		averageMark, содержащую среднюю оценку.

		Создать метод 
		getScholarship() для класса Student, который возвращает сумму стипендии. Если средняя оценка студента равна 5, то сумма 200c, иначе 500c. 
		Переопределить этот метод в классе Aspirant.  
		Если средняя оценка аспиранта равна 5, то сумма 2500c, иначе 2200c.
		Создать массив типа Student, содержащий объекты класса Student и Aspirant. 
		Вызвать метод getScholarship() для каждого элемента массива.
############################################################################################################
7.Задание 
		Автомобили
		Создать класс Car.
		Класс Driver содержит поля 
		ФИО, 
		стаж вождения.
		
		Класс Engine содержит поля 
		мощность, 
		производитель.

		Класс Car
		содержит поля 
		марка автомобиля, 
		класс автомобиля, 
		вес, 
		водитель типа Driver, 
		мотор типа Engine. 
		
		Методы 
		start(), 
		stop(), 
		turnRight(), 
		turnLeft(), 
		которые выводят на печать: "Поехали", "Останавливаемся", "Поворот направо" или "Поворот налево". 
		А также метод toString(), который выводит полную информацию об автомобиле, ее водителе и моторе. 
############################################################################################################
8.Задание
	Животные
		Создать класс Animal и расширяющие его абстрактные классы Dog, Cat, Bear.
		Класс Animal содержит переменную 
		name 
		
		абстрактные методы 
		makeNoise, 
		eat, 
		getDescription. 
		
		Метод makeNoise, например, может выводить на консоль звуки животных. 
		Метод  eat выводит на консоль список того, чем питается данное животное. 
		Метод getDescription возвращает описание животного.
		
		Dog, Cat, Bear переопределяют методы makeNoise, eat, getDescription.
		Создайте класс Ветеринар, в котором определите метод void treatAnimal(Animal animal). 
		Пусть этот метод распечатывает name и описание пришедшего на прием животного.
		В методе main создайте массив типа Animal, в который запишите животных всех имеющихся у вас типов. 
		В цикле отправляйте их на прием к ветеринару. 
		В отдельном цикле вызовите методы  makeNoise, eat для каждого животного.
############################################################################################################
9.Задание
	Фигуры
		Создайте супер класс Shape и его наследников Circle, Rectangle.
		Класс Shape содержит абстрактный метод draw() и переменную хранящую цвет.
		Классы Circle, Rectangle содержат координаты точек.
		Создать массив содержащий эти фигуры.
		В цикле нарисовать их (вызвать метод draw).
############################################################################################################
10.Задание
	Интернет магазин
		Создать класс Товар, 
		имеющий переменные 
		имя, 
		цена, 
		рейтинг. 
		Создать класс Категория, 
		имеющий переменные 
		имя 
		массив товаров. 
		
		Создать несколько объектов класса Категория. 
		Создать класс Basket, содержащий массив купленных товаров. 
		Создать класс User, содержащий 
		логин, 
		пароль 
		объект класса Basket. 
		Создать несколько объектов класса User.
		Вывести на консоль каталог продуктов.
		Вывести на консоль покупки посетителей магазина.
############################################################################################################
11.Задание
		Дрел Перфаратор

		Создать класс Дрел Перфаратор, 
		имеющий переменные 
		имя, 
		скорост,
		реверс 
		
		методи:
		Констркустор перегрузка должна бит
		Start()
		Stop()
		Reverse()
		Mode()
		Speed()
############################################################################################################
12.Задание	

		Создать класс Мултиметер, 
		имеющий переменные 
		имя, 
		значения,
		диапазон значения

		методи:
		Констркустор перегрузка должна бит
		CheckVolt()
		CheckAmper()
		CheckOhm()
		CheckCell()
		Mode()
		PleseOfShoop()
############################################################################################################
13.Задание	

		Создать класс Мыш компютерний, 
		имеющий переменные
		x,
		y,
		Postion,
		CountOfButton,
		State

		методи:
		Констркустор перегрузка должна бит

		On()
		Off()
		Click()
		MoveLeft()
		MoveBack()		
		MoveFront()
		MoveRight()
		EventKeyUp()
		DoubleClick()
		EventKeyDown()
############################################################################################################
14.Задание	

		Создать класс Клавиатура компютерний, 
		имеющий переменные
		KeyChar
		KeyCode
		StateOfCapsLock
		StateOfNumLock
		StateOfScrollLock

		методи:
		Констркустор перегрузка должна бит

		On()
		Off() 
		EventKeyUp()
		EventKeyDown()
		ChangeStateOfCapsLock()
		ChangeStateOfNumLock()
		ChangeStateOfScrollLock()
############################################################################################################
15.Задание	

		Создать класс Calc, 
		имеющий переменные
		a,
		b
		res

		методи:
		Констркустор перегрузка должна бит

		Sum()
		Sub()
		Mul()
		Div()
		Sqrt()
		Mod()
		Neg()
		Pow()
############################################################################################################
16.Задание	

		Создать класс Calc, 
		имеющий переменные
		a,
		b
		res

		методи:
		Констркустор перегрузка должна бит

		Sum()
		Sub()
		Mul()
		Div()
		Sqrt()
		Mod()
		Neg()
		Pow()	
############################################################################################################
17.Задание	

		Создать Messenger, 
		имеющий переменные
		Name
		Number
		Status

		методи:
		Констркустор перегрузка должна бит

		Send()
		Recive()
		WriteText()
		AddPhoto()
		AddVideo()
		AddMusic()
		AddContact()

		CreateGroup()
		AddMemberToGroup()
		LeaveFromFromGroup()
		DeleteGroupfromMember()
############################################################################################################
18.Задание	

		Создать Browser, 
		имеющий переменные
		Url
		CoutOfPage
		CurrentPage

		методи:
		Констркустор перегрузка должна бит

		Back()
		Next()
		EditUrl()
		Refresh()
		ShowHistory()
		AddPageToHome()
############################################################################################################
19.Задание	

		Создать Browser, 
		имеющий переменные
		Url
		CoutOfPage
		CurrentPage

		методи:
		Констркустор перегрузка должна бит

		Back()
		Next()
		EditUrl()
		Refresh()
		ShowHistory()
		AddPageToHome()

		19.Задание	

		Создать Browser, 
		имеющий переменные
		Url
		CoutOfPage
		CurrentPage

		методи:
		Констркустор перегрузка должна бит

		Back()
		Next()
		EditUrl()
		Refresh()
		ShowHistory()
		AddPageToHome()
############################################################################################################
20.Задание	

		Создать Player,
		имеющий переменные
		NameAlbum
		Author
		Singer
		PlayListName
		Speed

		методи:
		Констркустор перегрузка должна бит

		Play()
		Pause()
		NextTrack()
		BackTrack()
		Pause()
		Stop()
		Speed
############################################################################################################
21.Задание	

		Создать Projector,
		имеющий переменные
		Name
		width,
		height,
		sizeofDispaly
		Status
		StatusMode

		методи:
		Констркустор перегрузка должна бит

		Play()
		Pause()
		NextTrack()
		BackTrack()
		Pause()
		Stop()
		Speed()
############################################################################################################
22.Задание	

		Создать WashMashine,
		имеющий переменные
		Name
		State
		Mode
		Speed

		методи:
		Констркустор перегрузка должна бит

		Start()
		Stop()
		ChoseMode()
		AddWater()
		OpenDoor()
		CloseDoor()
		ClearWater()
############################################################################################################
23.Задание	

		Создать TV,
		имеющий переменные
		Name
		Status
		InputMode
		Tuner
		Channel
		Volume

		методи:
		Констркустор перегрузка должна бит

		On()
		Off()
		Mute()
		ChannelUp()
		ChannelDown()
		VolumeUp()
		VolumeDown()
		ChangeTuner()
		ChangeInput()
############################################################################################################
24.Задание	

		Создать DVD,
		имеющий переменные
		Name
		Status
		OutputMode
		DiskType
		Volume
		Track

		методи:
		Констркустор перегрузка должна бит

		On()
		Off()
		Mute()
		NextTrack()
		PrevTrack()
		VolumeUp()
		VolumeDown()
		NextScore()
		PrewScore()
		Pause()
		Stop()
		Play()
		Eject()
		Close()
############################################################################################################
25.Задание	

		Создать обект для вичесления плошад и приметер гемометрических фигур
		[
			Квадрат,
			Прямоуголник,
			ПрямоуголнийТриуголник
			РавносторонийТриуголник
			Колсо
			Трапетсия
		],
		имеющий переменные
		a,
		b,
		c,
		d,
		R,
		P,
		S

		методи:
		Констркустор перегрузка должна бит

		SquareOfSquare(), 
		SquareOfRectangle(),
		SquareOfRectangular()
		SquareOfTriangle()
		SquareOfEquilateral()
		SquareOfTriangle()
		SquareOfCircle()
		SquareOfTrapezium()

		PerimeterOfSquare(), 
		PerimeterOfRectangle(),
		PerimeterOfRectangular()
		PerimeterOfTriangle()
		PerimeterOfEquilateral()
		PerimeterOfTriangle()
		PerimeterOfCircle()
		PerimeterOfTrapezium()
############################################################################################################
26.Задание	

		Создать обект для решения квадратический уравнения
		[
			ax^2 = 0, 
			ax^2 + b = 0,
			ax^2 + bx = 0,
			ax^2 + bx + c = 0 
		],
		имеющий переменные
		a,
		b,
		c,
		d,
		x1,
		x2,
		D

		методи:
		Констркустор перегрузка должна бит

		ax2_0()
		ax2_b_0()
		ax2_bx_0()
		ax2_bx_c_0()