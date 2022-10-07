/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Сделать иерахию для ИОГВ                                     */
/* Created on:     27.04.2015 21:44:47                          */
/*==============================================================*/

alter table dbo.IogvRef
   add IogvIdx int         null default 1;
go

alter table dbo.IogvRef
   add ParentIogv varchar(512)         null
go

alter table dbo.IogvRef
   add constraint IogvRef_IogvRef foreign key (ParentIogv)
      references dbo.IogvRef (Iogv)
         on update cascade on delete cascade
go

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Руководство правительства ЕАО', null, 1);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Аппарат губернатора и правительства ЕАО', null, 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Департамент по обращениям граждан аппарата губернатора и правительства ЕАО', 'Аппарат губернатора и правительства ЕАО', 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Департамент пресс-службы губернатора', 'Аппарат губернатора и правительства ЕАО', 10);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Органы исполнительной власти, формируемые правительством ЕАО', null, 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Представительство правительства ЕАО при правительстве РФ', null, 4);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Суды ЕАО', null, 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Суд ЕАО', 'Суды ЕАО', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Арбитражный суд ЕАО', 'Суды ЕАО', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биробиджанский районный суд', 'Суды ЕАО', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биробиджанский гарнизонный военный суд', 'Суды ЕАО', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Мировые судьи ЕАО', 'Суды ЕАО', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Отдел Судебного департамента в ЕАО', 'Суды ЕАО', 6);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Правоохранительные органы', null,6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Прокуратура ЕАО', 'Правоохранительные органы', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Следственное управление Следственного комитета РФ по ЕАО', 'Правоохранительные органы', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Прокуратура города Биробиджана', 'Правоохранительные органы', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Министерства внутренних дел РФ по ЕАО', 'Правоохранительные органы', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Государственная инспекция безопасности дорожного движения УМВД РФ по ЕАО', 'Правоохранительные органы', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Отдел Федеральной миграционной службы России  по ЕАО', 'Правоохранительные органы', 6);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Территориальные органы исполнительной власти', null, 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Главный федеральный инспектор по ЕАО', 'Территориальные органы исполнительной власти', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Главное управление МЧС России по ЕАО', 'Территориальные органы исполнительной власти', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Представительство Министерства иностранных дел РФ в г. Хабаровске', 'Территориальные органы исполнительной власти', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Военный комиссариат ЕАО', 'Территориальные органы исполнительной власти', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Отдел по Еврейской автономной области Главного управления Минюста России по Хабаровскому краю и Еврейской автономной области', 'Территориальные органы исполнительной власти', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы исполнения наказаний по ЕАО', 'Территориальные органы исполнительной власти', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы судебных приставов по ЕАО ', 'Территориальные органы исполнительной власти', 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Отдел государственной фельдъегерской службы РФ в г. Биробиджане (Отдел ГФС России в г. Биробиджане)', 'Территориальные органы исполнительной власти', 8);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы безопасности РФ по ЕАО', 'Территориальные органы исполнительной власти', 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Служба в г. Биробиджане Пограничного управления Федеральной службы безопасности Российской Федерации по Хабаровскому краю и ЕАО', 'Территориальные органы исполнительной власти', 10);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Служба по ЕАО Регионального управления Федеральной службы РФ по контролю за оборотом наркотиков по Хабаровскому краю (Служба по ЕАО РУФСКН РФ по Хабаровскому краю)', 'Территориальные органы исполнительной власти', 11);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Центр специальной связи и информации Федеральной службы охраны РФ в ЕАО', 'Территориальные органы исполнительной власти', 12);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы по надзору в сфере защиты прав потребителей и благополучия человека по ЕАО (Управление Роспотребнадзора по ЕАО)', 'Территориальные органы исполнительной власти', 13);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Территориальный орган Федеральной службы по надзору в сфере здравоохранения по Еврейской автономной области (Управление Росздравнадзора по ЕАО)', 'Территориальные органы исполнительной власти', 14);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Государственная инспекция труда в ЕАО', 'Территориальные органы исполнительной власти', 15);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы по надзору в сфере природопользования (Росприроднадзор) по ЕАО', 'Территориальные органы исполнительной власти', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление по недропользованию по ЕАО (Бирнедра)', 'Территориальные органы исполнительной власти', 17);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Отдел водных ресурсов по ЕАО Амурского бассейнового водного управления Федерального агентства водных ресурсов', 'Территориальные органы исполнительной власти', 18);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы по надзору в сфере связи, информационных технологий и массовых коммуникаций по Дальневосточному федеральному округу', 'Территориальные органы исполнительной власти', 19);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биробиджанский территориальный отдел (Управление Роскомнадзора по Хабаровскому краю и ЕАО)', 'Территориальные органы исполнительной власти', 20);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы по ветеринарному и фитосанитарному надзору по Хабаровскому краю и ЕАО', 'Территориальные органы исполнительной власти', 21);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Территориальный отдел по Еврейской автономной области Дальневосточного межрегионального управления государственного автодорожного надзора', 'Территориальные органы исполнительной власти', 22);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной налоговой службы по ЕАО', 'Территориальные органы исполнительной власти', 23);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Главное управление Центрального банка РФ по ЕАО (ГУ Банка России по ЕАО)', 'Территориальные органы исполнительной власти', 24);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Отдел по Еврейской автономной области Межрегионального территориального управления Федеральной службы финансово-бюджетного надзора в Хабаровском крае', 'Территориальные органы исполнительной власти', 25);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федерального казначейства по ЕАО', 'Территориальные органы исполнительной власти', 26);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Территориальный орган Федеральной службы государственной статистики по ЕАО (Еврстат)', 'Территориальные органы исполнительной власти', 27);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Территориальное управление Федерального агентства по управлению государственным имуществом по ЕАО (ТУ Росимущества по ЕАО)', 'Территориальные органы исполнительной власти', 28);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной службы государственной регистрации, кадастра и картографии по ЕАО', 'Территориальные органы исполнительной власти', 29);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной антимонопольной службы по ЕАО (Еврейской УФАС России)', 'Территориальные органы исполнительной власти', 30);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биробиджанская таможня', 'Территориальные органы исполнительной власти', 31);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биробиджанский отдел по надзору за промышленной и энергетической безопасностью Дальневосточного управления Ростехнадзора', 'Территориальные органы исполнительной власти', 32);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Фонды', null, 8);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Государственное учреждение – Отделение Пенсионного фонда РФ по ЕАО', 'Фонды', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Государственное учреждение – Региональное отделение Фонда социального страхования РФ по ЕАО', 'Фонды', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Территориальный фонд обязательного медицинского страхования ЕАО', 'Фонды', 3);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Федеральные бюджетные учреждения', null, 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Федеральное государственное бюджетное учреждение «Управление мелиорации земель и сельскохозяйственного водоснабжения по ЕАО» («Биробиджанмелиоводхоз)»', 'Федеральные бюджетные учреждения', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Федеральное бюджетное учреждение «Государственный региональный центр стандартизации, метрологии и испытаний в Еврейской автономной области» (ФБУ «ЦСМ ЕАО»)', 'Федеральные бюджетные учреждения', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Управление Федеральной почтовой связи ЕАО – филиал ФГУП «Почта России»', 'Федеральные бюджетные учреждения', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Филиал ФГУП ВГТРК государственная телевизионная и радиовещательная компания «Бира» (ГТРК «Бира»)', 'Федеральные бюджетные учреждения',4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Филиал федерального государственного бюджетного учреждения «Федеральная кадастровая палата Федеральной службы государственной регистрации, кадастра и картографии» по ЕАО', 'Федеральные бюджетные учреждения', 5);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Областные организации и учреждения', null, 10);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Федерация профсоюзов ЕАО', 'Областные организации и учреждения', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Областное государственное казенное учреждение «Государственный архив ЕАО»', 'Областные организации и учреждения', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('ОГБУ «Центр по обеспечению полномочий ЕАО в вопросах гражданской обороны, защиты населения и территорий от чрезвычайных ситуаций и пожарной безопасности»', 'Областные организации и учреждения', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Областное государственное казенное учреждение «Управление административными зданиями»', 'Областные организации и учреждения', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Областное государственное автономное учреждение «Издательский дом «Биробиджан»', 'Областные организации и учреждения', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Областное государственное казенное учреждение «Централизованная бухгалтерия органов исполнительной власти ЕАО»', 'Областные организации и учреждения', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Областное государственное казенное учреждение «Государственное юридическое бюро ЕАО»', 'Областные организации и учреждения', 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Адвокатская палата ЕАО', 'Областные организации и учреждения', 8);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Нотариальная палата ЕАО', 'Областные организации и учреждения', 9);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Ассоциация «Совет муниципальных образований ЕАО»', 'Областные организации и учреждения', 10);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Администрации (мэрия города) муниципальных образования ЕАО', null, 11);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Мэрия города Биробиджана', 'Администрации (мэрия города) муниципальных образования ЕАО', 1);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биробижанский муниципальный район', 'Администрации (мэрия города) муниципальных образования ЕАО', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Администрация Биробиджанского муниципального района', 'Биробижанский муниципальный район', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Птичнинское сельское поселение', 'Биробижанский муниципальный район', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Валдгеймское сельское поселение', 'Биробижанский муниципальный район', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Найфельдское сельское поселение', 'Биробижанский муниципальный район', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Дубовское сельское поселение', 'Биробижанский муниципальный район', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Надеждинское сельское поселение', 'Биробижанский муниципальный район', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Бирофельдское сельское поселение', 'Биробижанский муниципальный район', 7);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Ленинский муниципальный район', 'Администрации (мэрия города) муниципальных образования ЕАО', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Администрация Ленинского муниципального района', 'Ленинский муниципальный район', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Ленинское сельское поселение', 'Ленинский муниципальный район', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Бабстовское сельское поселение', 'Ленинский муниципальный район', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Лазаревское сельское поселение', 'Ленинский муниципальный район', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Дежневское сельское поселение', 'Ленинский муниципальный район', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Биджанское сельское поселение', 'Ленинский муниципальный район', 6);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Смидовичский муниципальный район', 'Администрации (мэрия города) муниципальных образования ЕАО', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Администрация Смидовичского муниципального района', 'Смидовичский муниципальный район', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Смидовичское городское поселение', 'Смидовичский муниципальный район', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Волочаевское городское поселение', 'Смидовичский муниципальный район', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Николаевское городское поселение', 'Смидовичский муниципальный район', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Приамурское городское поселение', 'Смидовичский муниципальный район', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Волочаевское сельское поселение', 'Смидовичский муниципальный район', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Камышовское сельское поселение', 'Смидовичский муниципальный район', 7);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Облученский муниципальный район', 'Администрации (мэрия города) муниципальных образования ЕАО', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Администрация Облученского муниципального района', 'Облученский муниципальный район', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Облученское городское поселение', 'Облученский муниципальный район', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Известковское городское поселение', 'Облученский муниципальный район', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Бираканское городское поселение', 'Облученский муниципальный район', 4);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Кульдурское городское поселение', 'Облученский муниципальный район', 5);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Теплоозерское городское поселение', 'Облученский муниципальный район', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Бирское городское поселение', 'Облученский муниципальный район', 7);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Пашковское сельское поселение', 'Облученский муниципальный район', 8);

Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Октябрьский муниципальный район', 'Администрации (мэрия города) муниципальных образования ЕАО', 6);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Администрация Октябрьского муниципального района', 'Октябрьский муниципальный район', 1);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Амурзетское сельское поселение', 'Октябрьский муниципальный район', 2);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Полевское сельское поселение', 'Октябрьский муниципальный район', 3);
Insert into IogvRef ([Iogv],[ParentIogv], [IogvIdx]) Values('Нагибовское сельское поселение', 'Октябрьский муниципальный район', 4);
