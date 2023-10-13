package models

import "fmt"

type ProjectorInterface interface {
	SetCustomSize()
	SetFocus()
	SetMode()
	Turn()
	GetInfo()
}

type Size struct {
	Height int // длина, пикс.
	Width  int // ширина, пикс.
}

type Focus struct {
	FocusDistance int // фокусное расстояние - мм
}

type Mode struct {
	Name string // название режима - HDMI
}

type Projector struct {
	Name   string
	Size   Size
	Focus  Focus
	Mode   Mode
	Status bool
}

func (p *Projector) SetCustomSize() {
	var height, width int
	fmt.Print("Введите  высоту: ")
	fmt.Scan(&height)
	fmt.Print("Введите  ширину: ")
	fmt.Scan(&width)
	size := Size{
		Height: height,
		Width:  width,
	}
	p.Size = size
	fmt.Printf("Установлены пользовательские размеры проектора: %d на %d\n", height, width)
}

func (p *Projector) SetFocus() {
	var focusDistance int
	fmt.Print("Введите  фокусное расстояние: ")
	fmt.Scan(&focusDistance)
	focus := Focus{
		FocusDistance: focusDistance,
	}
	p.Focus = focus
	fmt.Printf("Установлен фокусное расстояние %d мм\n", focus.FocusDistance)
}

func (p *Projector) SetMode() {
	fmt.Printf("Выберите режим проектора.\n " +
		"1 - HDMI\n " +
		"2 - VGA\n")
	var modeNumber int
	fmt.Scan(&modeNumber)
	var mode Mode
	switch modeNumber {
	case 1:
		mode = Mode{Name: "HDMI"}
	case 2:
		mode = Mode{Name: "VGA"}
	default:
		fmt.Println("Неизвестная команда")
	}
	p.Mode = mode
	fmt.Printf("Установлен режим %s\n", mode.Name)
}

func (p *Projector) Turn() {
	if p.Status {
		p.Status = false
		fmt.Println("Проектор выключен")
	} else {
		p.Status = true
		fmt.Println("Проектор включен")
	}
}

func (p *Projector) GetInfo() {
	fmt.Printf("Проектор: %s, Размер: %d на %d, Фокусное расстояние: %d мм, Режим: %s, Статус: %t\n",
		p.Name, p.Size.Height, p.Size.Width, p.Focus.FocusDistance, p.Mode.Name, p.Status)
}
