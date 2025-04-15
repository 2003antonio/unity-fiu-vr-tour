# 🏫 VR Campus Tour – FIU MMC

This Unity-based Virtual Reality experience allows new students and visitors to explore Florida International University’s MMC campus through an immersive guided tour. Built using the **Meta SDK**, this application provides a scalable and interactive solution that can be extended to other universities or businesses.

---

## 🎮 Project Overview

- **Platform**: Unity (VR, built for Meta Quest)
- **SDK**: Meta XR SDK (OVR Integration)
- **Goal**: Improve campus orientation through immersive VR walkthroughs
- **Key Features**:
  - Teleport-based navigation between locations
  - Info popups and 360° views
  - Fade transition effects
  - Modular scene structure for scalability

---

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
  - AR overlays (for mobile campus apps)

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
