package main

import (
	"Task21/projector"
	"fmt"
)

func main() {

	proj := &projector.Projector{
		Name:       "Canon",
		Model:      "LV-X310ST",
		Size:       projector.Size{},
		Focus:      projector.Focus{},
		Mode:       projector.Mode{},
		Brightness: 50,
		Status:     false,
	}

	var projectorIF projector.InterfaceProjector
	projectorIF = proj

	for {
		fmt.Println("-----------------------------------------")
		fmt.Printf("Выберите команду для настройки проектора\n" +
			"0 - Выключить\n" +
			"1 - Включить\n" +
			"2 - Установить разрешение\n" +
			"3 - Установить фокусное растояние\n" +
			"4 - Переключить вход\n" +
			"5 - Уменьшить яркость\n" +
			"6 - Увеличить яркость\n" +
			"7 - Получить информацию\n")

		var command int
		fmt.Scan(&command)

		switch command {
		case 0:
			projectorIF.TurnOff()
		case 1:
			projectorIF.TurnOn()
		case 2:
			projectorIF.SetCustomSize()
		case 3:
			projectorIF.SetFocus()
		case 4:
			projectorIF.SetMode()
		case 5:
			projectorIF.BrightnessDown()
		case 6:
			projectorIF.BrightnessUp()
		case 7:
			projectorIF.GetInfo()
		default:
			fmt.Println("Неизвестная команда")
		}
	}

}
