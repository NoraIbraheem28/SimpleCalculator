# SimpleCalculator

## Overview

This is a simple calculator project implemented in c#. The calculator has a graphical user interface (GUI) with basic functionality, including addition, subtraction, multiplication, division, and clearing operations.

## Project Structure

The main code file (`form1.cs`) consists of three main methods:

<ol>
  <li>
    <b>"button_click" Method:</b>
    <ul>
      <li>Controls the functionality of the number buttons (0-9), decimal point button (.), and special buttons (C and CE).</li>
      <li>Handles the input and clears the input based on the button pressed.</li>
    </ul>
    <pre>
      private void button_click(object sender, EventArgs e)
      {
          // Implement button_click functionality here
      }
    </pre>
  </li>
  
  <li>
    <b>"operator_click" Method:</b>
    <ul>
      <li>Controls the functionality of the operator buttons (+, -, *, /).</li>
      <li>Manages the calculation and updates the display accordingly.</li>
    </ul>
    <pre>
      private void operator_click(object sender, EventArgs e)
      {
        //Implement operator_click functionality here 
      }
    </pre>
  </li>
  
  <li>
    <b>"button15_click" Method:</b>
    <ul>
      <li>Handles the = operation by utilizing a switch case to determine the appropriate calculation based on the operator.</li>
    </ul>
    <pre>
      private void button15_Click(object sender, EventArgs e)
      {
          // Implement button_click functionality here
      }
    </pre>
  </li>
</ol>
</li>

## Windows form window
<img src="https://github.com/NoraIbraheem28/SimpleCalculator/blob/main/Capture.JPG">


## Usage

To use the calculator, run `Form1.cs`. The GUI will appear, and you can interact with the calculator by clicking the number buttons, operator buttons, and special buttons (C and CE).
