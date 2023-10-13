package main

import (
	"fmt"
	"task23/tv"
)

func main() {
	televisor := tv.TV{
		Name:      "Samsung",
		Status:    false,
		InputMode: tv.InputMode{},
		Tuner:     tv.Tuner{},
		Channel:   tv.Channel{},
		Volume:    20,
	}

	for {
		fmt.Printf("Нажмите на команды для настройки TV: \n " +
			"0 - Выключить\n " +
			"1 - Включить\n " +
			"2 - Увеличить громкость\n " +
			"3 - Уменьшить громкость\n " +
			"4 - Без звука\n " +
			"5 - Сменить источник\n ")
		var command int
		fmt.Scan(&command)
		switch command {
		case 0:
			televisor.Off()
		case 1:
			televisor.On()
		case 2:
			televisor.VolumeUp()
		case 3:
			televisor.VolumeDown()
		case 4:
			televisor.Mute()
		case 5:
			televisor.ChangeInput()

		default:
			fmt.Println("Неизвестная команда")

		}
	}

}
