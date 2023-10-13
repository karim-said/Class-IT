package main

import (
	"fmt"
	"projector-class/models"
)

func main() {

	proj := &models.Projector{
		Name: "Canon",
		Size: models.Size{
			Height: 1920,
			Width:  1080,
		},
		Focus: models.Focus{
			FocusDistance: 10,
		},
		Mode: models.Mode{
			Name: "HDMI",
		},
		Status: false,
	}

	var projectorIF models.ProjectorInterface
	projectorIF = proj

	for {

		fmt.Println("===================================================")

		fmt.Printf("Введите число для настройки проектора.\n " +
			"1 - Настроить размер\n " +
			"2 - Настроить фокус\n " +
			"3 - Настроить режим\n " +
			"4 - Включить/Выключить\n " +
			"5 - Информация о проекторе\n ")

		var command int
		fmt.Scan(&command)

		switch command {
		case 1:
			projectorIF.SetCustomSize()
		case 2:
			projectorIF.SetFocus()
		case 3:
			projectorIF.SetMode()
		case 4:
			projectorIF.Turn()
		case 5:
			projectorIF.GetInfo()
		default:
			fmt.Println("Неизвестная команда")
		}

	}
}
