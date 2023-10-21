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

	channels := []tv.Channel{
		{
			Number: 1,
			Name:   "MIR",
		},
		{
			Number: 2,
			Name:   "NTV",
		},
		{
			Number: 3,
			Name:   "Animals",
		},
		{
			Number: 4,
			Name:   "Karusel",
		},
	}

	for {
		fmt.Printf("Нажмите на команды для настройки TV: \n " +
			"0 - Выключить\n " +
			"1 - Включить\n " +
			"2 - Увеличить громкость\n " +
			"3 - Уменьшить громкость\n " +
			"4 - Без звука\n " +
			"5 - Сменить источник\n " +
			"6 - Сменить канал\n ")
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
		case 6:
			televisor.ChangeChannel(channels)
		default:
			fmt.Println("Неизвестная команда")

		}
	}

}
