[![downloads](https://img.shields.io/github/downloads/Vacca576/CustomSize/total?style=for-the-badge&logo=icloud&color=%233A6D8C)](https://github.com/Vacca576/CustomSize/releases/latest)

# Custom-Size for EXILED

This plugin randomly assigns custom sizes to players when they spawn, enhancing gameplay variety by altering player perspectives and hitboxes in a fun and dynamic way.

## Features:
- **Random Size Assignment**: Assigns a random size to players upon spawn, adding a unique gameplay experience each round.
- **Configurable Sizes**: Allows for custom size values to fit your server's desired gameplay style.

### Requirements:
- **EXILED Version**: 8.9.11 or later

### Configuration

Here’s the default configuration for the `CustomSize` plugin. You can customize the sizes assigned to players and enable or disable the plugin’s debug mode.

```yaml
CustomSize:
  is_enabled: true      # Enables or disables the plugin
  debug: false          # Enables debug mode to log additional details (recommended for testing)
  size:                 
    - 1.0               # Standard size
    - 1.2               # Slightly larger size
```

- **`is_enabled`**: Set to `true` to enable the plugin.
- **`debug`**: Enable debug mode for additional logging, useful for testing and troubleshooting.
- **`size`**: Add as many size values as desired to introduce size variety. Each value represents a player's scale factor, where `1.0` is standard size, values greater than `1.0` increase size, and values less than `1.0` reduce size.

