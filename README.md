# Station Zero

A first-person survival horror game built in Unity 3D. You wake up alone on a failing orbital space station with no memory of what happened — and hostile security robots patrolling every hallway. Find five hidden power cells, restore power to the control room, and escape on the emergency shuttle before it's too late.

🎮 **[Play in Browser on Unity Play](https://play.unity.com/en/games/station-zero-final-project)**

---

---

## 🎮 Gameplay

Station Zero emphasizes stealth and exploration over combat. You can't fight the robots — you have to outsmart them.

- **Explore** a decaying space station across multiple sections and corridors
- **Collect 5 power cells** hidden throughout the station to unlock the control room
- **Avoid security robots** that patrol set paths and chase you on sight — getting caught means game over
- **Activate AI terminals** scattered around the station for story lore and hints on cell locations
- **Find the Repair Bot** — a friendly drone that follows you, opens locked doors, and highlights nearby power cells on your HUD
- **Escape** by reaching the control room with all five cells and activating the emergency shuttle

---

## 🕹️ Controls

| Action | Input |
|---|---|
| Move | WASD |
| Sprint | Shift |
| Jump | Space |
| Interact | E |
| Look | Mouse |

---

## 🛠️ Built With

- **Engine:** Unity 3D
- **Language:** C#
- **AI:** Unity NavMesh — enemy patrol paths, player detection, and pursuit behavior
- **Physics:** Rigidbody-based object interactions (push/move terminals and props)
- **Lighting:** Custom shaders and atmospheric sci-fi lighting for horror ambiance
- **Systems:** Lives/respawn system, inventory management, HUD, AI terminal dialogue, win/lose conditions

---

## 📦 Assets Used

| Asset | Purpose |
|---|---|
| [Sci-Fi Styled Modular Pack](https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913) | Station environment |
| [Starter Assets – First Person](https://assetstore.unity.com/packages/essentials/starter-assets-firstperson-updates-in-newcharactercontroller-pa-196525) | Player controller |
| [Robot Kyle URP](https://assetstore.unity.com/packages/3d/characters/robots/robot-kyle-urp-4696) | Security robot enemy |
| [Low Poly Combat Drone](https://assetstore.unity.com/packages/3d/characters/robots/low-poly-combat-drone-82234) | Repair bot companion |
| [HiTech Sci-Fi Energy Cell](https://assetstore.unity.com/packages/3d/environments/sci-fi/hitech-scifi-energy-cell-154526) | Collectible power cells |
| [HQ Laptop Computer](https://assetstore.unity.com/packages/3d/props/electronics/hq-laptop-computer-42030) | AI terminals |
| [Free Skyboxes – Sci-Fi/Fantasy](https://assetstore.unity.com/packages/2d/textures-materials/sky/free-skyboxes-sci-fi-fantasy-184932) | Skybox |
| [Free Sound Effects Pack](https://assetstore.unity.com/packages/audio/sound-fx/free-sound-effects-pack-155776) | General SFX |
| [Fantasy Loot & Crate Sounds](https://assetstore.unity.com/packages/audio/sound-fx/fantasy-loot-chest-crate-and-lootbox-sounds-297065) | Pickup sounds |

---

## 🚀 Getting Started

### Play in Browser
No install needed — **[play directly on Unity Play](https://play.unity.com/en/games/station-zero-final-project)**.

### Run Locally
1. Clone the repository
   ```bash
   git clone https://github.com/srb68/station-zero.git
   ```
2. Open in Unity Hub (Unity 2021.3 LTS or later recommended)
3. Open the main scene from `Assets/Scenes/`
4. Press **Play** in the Unity Editor

---

## 📁 Project Structure

```
Assets/
├── Scenes/          # Game scenes
├── Scripts/         # C# game logic (player, enemies, inventory, terminals)
├── Prefabs/         # Reusable game objects
├── Materials/       # Shaders and materials
├── Audio/           # Sound effects
└── Animations/      # Enemy and player animations
```

---

## 👤 Author

**Sneh Bhatt**  
[GitHub](https://github.com/srb68) · [LinkedIn](https://linkedin.com/in/sneh-bhatt-)  
New Jersey Institute of Technology — Computer Science, Dean's Scholar
