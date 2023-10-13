package models

import "fmt"

type ProjectorInterface interface {
	SetCustomSize(height, width int)
	SetFocus(focus Focus)
	SetMode(mode Mode)
	TurnOff()
	TurnOn()
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

func (p *Projector) SetCustomSize(height, width int) {
	p.Size.Height = height
	p.Size.Width = width
	fmt.Printf("Установлены пользовательские размеры проектора: %d на %d\n", height, width)
}

func (p *Projector) SetFocus(focus Focus) {
	p.Focus = focus
	fmt.Printf("Установлен фокусное расстояние %d мм\n", focus.FocusDistance)
}

func (p *Projector) SetMode(mode Mode) {
	p.Mode = mode
	fmt.Printf("Установлен режим %s\n", mode.Name)
}

func (p *Projector) TurnOff() {
	p.Status = false
	fmt.Println("Проектор выключен")
}

func (p *Projector) TurnOn() {
	p.Status = true
	fmt.Println("Проектор включен")
}

func (p *Projector) GetInfo() {
	fmt.Printf("Проектор: %s, Размер: %d на %d, Фокусное расстояние: %d мм, Режим: %s, Статус: %t\n",
		p.Name, p.Size.Height, p.Size.Width, p.Focus.FocusDistance, p.Mode.Name, p.Status)
}
