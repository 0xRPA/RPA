# RPA - Routine Process Agent

## Introduction

Routine Process Agent (RPA) enables the execution of rule-based, repetitive workflows without requiring human intervention. It continuously operates on a computer, executing structured tasks faster than humans while minimizing errors and fraud. As Robotic Process Automation technology matures, it becomes more precise in learning and mimicking human actions, optimizing business processes for efficiency. The integration of AI technologies such as facial recognition, natural language interaction, image recognition, and automation control further extends RPA capabilities to intelligent decision-making tasks.

RPA consists of three core components:

- **Designer**: A drag-and-drop, code-free visual interface for workflow configuration.
- **Executor**: The execution agent that processes automated tasks.
- **OCR Engine**: Enables optical character recognition for handling document-based automation.

## Components

### Designer

The workflow Designer provides a fully visualized process design environment, allowing users to create workflows without writing code. It includes:

- A comprehensive set of built-in nodes to handle different business scenarios.
- Intelligent suggestions, debugging tools, and an integrated development environment (IDE)-like experience.
- The ability to publish designed workflows directly for execution.

### Executor

The Executor is responsible for running deployed automation workflows. It supports two execution modes:

- **Unattended Automation**: Fully automated execution without human intervention. The Executor runs as a background service, processing tasks autonomously.
- **Attended Automation**: Enables human-machine collaboration for scenarios where human oversight is required. Users can focus on key decision points while automation handles routine tasks.

![architecture](RPA.png)

## Supported Operating Systems

RPA is compatible with the following operating systems:

- Windows 10
- Windows Server 2016
- Windows Server 2019
- Windows Server 2022
- Windows Server 2025

## Prerequisites

The RPA Designer and Executor require .NET Framework 4.6.1 or later. Windows 10 and Windows Server 2016 or newer come pre-installed with the required framework.

### Hardware Requirements

| Hardware  | Minimum Requirement  | Recommended Requirement  |
|-----------|----------------------|--------------------------|
| CPU       | Intel Core i3        | Intel Core i7            |
| RAM       | 2 GB                 | 8 GB                     |
| Storage   | 5 GB available       | 20 GB+ available         |
| Network   | 100 Mbps adapter     | 1 Gbps adapter           |

## Features

### Visual Workflow Design

RPA enables fully visualized process configuration with a drag-and-drop interface. It includes over 300 built-in nodes, requiring only minimal parameter configuration to complete complex automation tasks.

### Programming Language Support

The system supports VB.NET, allowing users to integrate script-based automation with visual workflow design. RPA workflows can directly invoke .NET Framework methods, offering extended automation capabilities.

### Parameters and Variables

RPA supports both parameters and variables for dynamic workflow execution. Parameters facilitate information transfer between workflows, while variables handle internal storage and logic. Type enforcement ensures consistency and prevents execution failures.

### Core Action Nodes

Commonly used operations include:

- **Assign Node**: Assigns values to parameters or variables.
- **Multi-Assign Node**: Assigns multiple values simultaneously.
- **WriteLine Node**: Logs debug information.
- **Delay Node**: Introduces execution pauses.

### Flow Control Nodes

RPA supports various flow control mechanisms, including:

- **Sequential Workflow**: Executes tasks in a step-by-step sequence.
- **Flowcharts**: Visualizes complex decision trees and branching paths.
- **State Machines**: Implements process state transitions.
- **Conditional Branching**: If-Else, Switch, and Pick nodes enable decision-making logic.
- **Looping Constructs**: While, Do-While, ForEach, and Parallel ForEach facilitate iterative task execution.

### UI Automation  

RPA enables interaction with user interfaces, allowing automated workflows to perform tasks just as a human would. It can simulate mouse clicks, keystrokes, and navigation actions to interact with various applications, ensuring smooth execution of UI-dependent processes.  

- **Desktop Applications**: Desktop applications refer to software programs that run directly on the Windows operating system, such as Microsoft Office Word, Notepad, and Photoshop. Unlike web-based applications that run in a browser, desktop applications have their user interfaces rendered by the operating system. RPA automates interactions with these applications using low-level Windows system interfaces to execute actions like clicking, typing, and data extraction.
- **Web Browsers**:  
  - **Internet Explorer**: IE can be considered a specialized desktop application. Web pages rendered in IE are parsed from HTML files and displayed using the operating system’s graphic engine. Therefore, automation for IE follows a similar approach to desktop application automation, leveraging Windows UI automation.
  - **Chrome & Firefox**: Compared to Microsoft's IE browser, Chrome provides a more open extension mechanism. By utilizing browser extensions, RPA can access internal browser interfaces and automate HTML elements using JavaScript APIs. In addition to traditional UI automation techniques, Chrome automation can be enhanced through browser plugins, providing more flexibility for interacting with web pages.  Firefox, like Chrome, supports JavaScript-based UI automation via browser extensions. Once the corresponding plugin is installed, automation steps are identical to those in Chrome, enabling smooth automation of browser interactions.
- **Computer Vision**: In UI automation, there may be scenarios where recognizing certain UI elements (such as images) is necessary. In such cases, Computer Vision techniques can be used to detect and interact with visual elements. The system includes various machine vision capabilities, such as table recognition nodes, which can extract specific column data from tabular images, enhancing automation flexibility in complex UI environments. 

### Application Integration

RPA seamlessly integrates with:

- **Excel**: Reads and writes spreadsheet data. During UI automation, it may be necessary to recognize certain visual elements on the interface, such as images. In such cases, Computer Vision can be utilized to accomplish this task. RPA will integrate various machine vision techniques, including table recognition nodes, which can identify table-like images and extract specified column data from them.
- **Word**: Manipulates text, images, and tables.
- **Email**: Monitors inboxes, downloads attachments, and sends emails via POP3, IMAP, SMTP, and Exchange.
- **Databases**: Supports Oracle, MySQL, MS SQL Server, PostgreSQL, SQLite, and MongoDB.

### Exception Handling

Error handling is a crucial part of RPA workflow design. RPA provides:

- **Try-Catch-Finally Blocks**: Implements structured exception handling.
- **Custom Error Handling**: Captures and processes specific exception types.
- **Alerts & Notifications**: Sends alerts via email or SMS when exceptions occur.

### Configuration Management

- Centralized configuration settings for streamlined workflow adjustments.
- Secure credential management with encrypted storage of login credentials.

### Logging & Reporting

- Comprehensive logging of execution steps for monitoring and debugging.
- Custom log messages can be inserted at any workflow step.
- Visual dashboards to track automation performance.

### Task Scheduling

- Define task execution frequency down to the second.
- Supports daily, weekly, and monthly scheduling patterns.
- Ensures 24/7 automation with no manual intervention.

### Security Mechanisms

#### Password Protection

- SecureString encryption ensures credentials remain protected during execution.
- Password input fields can be hidden to prevent exposure.

#### Role-Based Access Control

- Granular permission settings restrict access to sensitive automation assets.
- Multi-user collaboration with controlled access levels.

#### Screen Monitoring

- Periodic screenshots capture execution steps for auditability.
- Enables real-time supervision of RPA activities.

## Installation & Setup

To install RPA:

1. Download the latest release from the repository.
2. Ensure .NET Framework 4.6.1+ is installed.
3. Run the setup executable and follow the on-screen instructions.
4. Launch the RPA Designer to create workflows or deploy workflows to the Executor.

## Contribution Guidelines

Contributions to the RPA project are welcome. To submit improvements:

1. Fork the repository.
2. Create a feature branch.
3. Commit changes with descriptive messages.
4. Submit a pull request for review.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
