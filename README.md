# Class-library-and-applications-based-on-it-Electronic-Journal-
C# Class library and applications based on it "Electronic Journal"

«Электронный журнал». Библиотека классов, в которой заключаются все классы и методы для работы приложения и базы данных. Использование Entity Framework для работы с базой данных. Создано приложение на основе Windows Forms.
Основные возможности приложения заключаются в заполнении и редактировании электронного дневника. Пользователь с правами «Преподаватель» имеет возможность просмотреть расписание, изменить или заполнить поля: «домашнее задание» и «оценка». Также присутствует выбор дня недели для полного редактирования расписания, а именно — удаление уроков, добавление новых уроков, изменение уроков, домашнего задания и оценок. При сохранении изменений происходит обновление информации в базе данных.

Главный поток(Преподаватель):
1.	Преподаватель выбирает режим пользователя
2.	Система загружает модуль электронного журнала
3.	Преподаватель выбирает день и неделю для редактирования
4.	Система открывает модуль редактирования расписания предметов
А1. Преподаватель изменяет расписание
А2. Преподаватель удаляет расписание
А3. Преподаватель добавляет новое расписание
5.	Система сохраняет изменения в расписании
6.	Преподаватель просматривает недели выставляет оценки
7.	Система сохраняет изменения в базе данных
8.	Вариант использования завершается

Альтернативный поток:
А1. Преподаватель изменяет существующее расписание
1.	Преподаватель вводит новое домашнее задание
2.	Преподаватель изменяет предмет
3.	Преподаватель выставляет оценки
4.	Возврат к пункту №5
А2. Преподаватель удаляет расписание
1.	Преподаватель удаляет расписание
2.	Возврат к пункту №5
А2. Преподаватель добавляет новое расписание
1.	Заполняет расписание
2.	Возврат к пункту №5

Главный поток(Ученик):
1.	Ученик выбирает режим пользователя
2.	Система загружает модуль электронного журнала
3.	Ученик просматривает расписание по дням недели
4.	 Вариант использования завершается
