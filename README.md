# 🏫 VR Campus Tour – FIU MMC

This Unity-based Virtual Reality experience allows new students and visitors to explore Florida International University’s MMC campus through an immersive guided tour. Built using the **Meta XR SDK**, it’s designed as a scalable template that can be extended to other campuses, organizations, or businesses.

---

## 🎮 Project Overview

- **Platform**: Unity (VR, Meta Quest)  
- **SDK**: Meta XR SDK (OVR Integration)  
- **Goal**: Improve campus orientation via an immersive VR walkthrough  
- **Key Features**:  
  - Teleport-based navigation  
  - Info pop-ups with 360° panoramas  
  - Smooth fade-in/fade-out transitions  
  - Modular scene structure for easy expansion  

---

## 📂 Directory Structure

```text
Assets/
├── 2d photos/        # UI sprites & info-popup backplates
├── 360 final/        # 360° environment panoramas
├── Materials/        # Unity materials & texture assignments
├── Models/           # 3D building & prop models
├── Oculus/           # Oculus XR Plugin config & samples
├── Plugins/          # Third-party Unity packages (Meta XR SDK, etc.)
├── Prefabs/          # Reusable GameObject prefabs (teleport points, pop-ups)
├── Resources/        # Runtime-loaded assets (fonts, audio, etc.)
├── Samples/          # Example scenes & demos
├── Scenes/           # .unity scene files (menu + all tour stops)
├── Script/           # C# source (teleport logic, UI controllers, scene manager)
├── Settings/         # ProjectSettings (input, graphics, player prefs)
├── Shaders/          # Custom .shader files (fade effects, overlays)
├── Sounds/           # Audio clips (ambient, narration, UI feedback)
├── Builds/           # Build artifacts
│   ├── Android/      # APK & OBB for Quest deployment
│   └── PC/           # Standalone Windows builds for testing
Docs/                 # User-facing documentation
├── Installation_Guide.pdf   # Step-by-step setup with screenshots
└── User_Manual.pdf          # End-user guide: controls, menus, troubleshooting

README.md
```


## 🛠️ Getting Started

### 1. Prerequisites
- Unity 2022.3 LTS (or compatible)
- Meta XR SDK (via Unity Asset Store or GitHub)
- Meta Quest device + Link Cable or AirLink for testing

### 2. Project Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/2003antonio/vr-campus-tour.git
   cd vr-campus-tour
   ```

2. Open the project in Unity Hub and ensure the correct Unity version is used.

3. Import the **Meta XR SDK** via the Unity Package Manager or Assets > Import Package.

4. Build settings:
   - Platform: Android
   - XR Plugin: Oculus
   - Set up your Android SDK & NDK in Unity preferences.

---

## 🧪 Testing Notes

- Use Meta Quest in Link Mode or through Build & Run.
- UI tested with **OVRCameraRig** + Unity Event System.
- Raycasts must avoid background canvas blocking input — make sure `Canvas` is set to **Ignore Raycast** when needed.

---

## 🧱 System Design

- Hierarchical scene structure for easy scalability
- Each location is modular and can be reused or repurposed
- Navigation logic handled through child `Transform` teleport points
- Future-ready for:
  - Multi-user collaboration
  - AI tour guide integration
  - AR overlays for mobile campus apps

---

## 💡 Vision

While built for FIU MMC, this system is intended to serve as a **template for any institution, organization, or business** seeking immersive spatial orientation, training, or interactive showcases.

---

## 👥 Team Credits

- **Antonio Martinez** – Team Lead / Lead Developer
- **Will Franco** – Product Manager
- **Christian Gonzalez** – Scrum Master
- **Garrett Baltar** – Lead Researcher
- **Andy Hernandez** – Lead Developer / Tester

---
