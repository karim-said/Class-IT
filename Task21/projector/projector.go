package projector

import "fmt"

type InterfaceProjector interface {
	TurnOff()        // выключить
	TurnOn()         // включить
	SetCustomSize()  // установить разрешение
	SetFocus()       // установить фокусное разрешение
	SetMode()        // установить режим
	BrightnessDown() // уменьшить яркость
	BrightnessUp()   // увеличить яркость
	GetInfo()        // получить информацию
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
	Name       string // название
	Model      string // модель
	Size       Size   // разрешение
	Focus      Focus  // фокусное расстояние
	Mode       Mode   // режим
	Brightness int    // яркость
	Status     bool   // состояние
}

func (p *Projector) TurnOff() {
	p.Status = false
	fmt.Printf("Проектор выключен\n")
}

func (p *Projector) TurnOn() {
	p.Status = true
	fmt.Printf("Проектор включен\n")
}

func (p *Projector) SetCustomSize() {
	var height, width int
	fmt.Print("Введите высоту: ")
	fmt.Scan(&height)
	if height <= 0 {
		fmt.Println("Неправильный ввод")
		return
	}
	fmt.Print("Введите ширину: ")
	fmt.Scan(&width)
	if width <= 0 {
		fmt.Println("Неправильный ввод")
		return
	}
	size := Size{
		Height: height,
		Width:  width,
	}
	p.Size = size
	fmt.Printf("Установлены пользовательские размеры проектора: %d на %d\n", height, width)
}

func (p *Projector) SetFocus() {
	var focusDistance int
	fmt.Print("Введите фокусное расстояние: ")
	fmt.Scan(&focusDistance)
	focus := Focus{
		FocusDistance: focusDistance,
	}
	p.Focus = focus
	fmt.Printf("Установлен фокусное расстояние %d мм\n", focus.FocusDistance)
}

func (p *Projector) SetMode() {
	fmt.Printf("Выберите режим: \n" +
		"1 - HDMI\n" +
		"2 - VGA\n" +
		"3 - DisplayPort\n" +
		"4 - USB\n" +
		"5 - Ethernet\n")
	var modeNumber int
	fmt.Scan(&modeNumber)
	var mode Mode
	switch modeNumber {
	case 1:
		mode.Name = "HDMI"
	case 2:
		mode.Name = "VGA"
	case 3:
		mode.Name = "DisplayPort"
	case 4:
		mode.Name = "USB"
	case 5:
		mode.Name = "Ethernet"
	default:
		fmt.Println("Неизвестный режим")
	}
	p.Mode = mode
	fmt.Printf("Установлен режим %s\n", mode.Name)
}

func (p *Projector) BrightnessDown() {
	if p.Brightness > 0 {
		p.Brightness--
	}
	fmt.Printf("Яркость %d\n", p.Brightness)
}

func (p *Projector) BrightnessUp() {
	if p.Brightness < 100 {
		p.Brightness++
	}
	fmt.Printf("Яркость %d\n", p.Brightness)
}

func (p *Projector) GetInfo() {
	fmt.Printf("Проектор: %s, Размер: %d на %d, Фокусное расстояние: %d мм, Яркость: %d, Режим: %s, Статус: %t\n",
		p.Name, p.Size.Height, p.Size.Width, p.Focus.FocusDistance, p.Brightness, p.Mode.Name, p.Status)
}
