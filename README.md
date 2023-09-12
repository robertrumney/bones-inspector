# Bones-Inspector

Expose and modify the bones array of a `SkinnedMeshRenderer` directly in the Unity Inspector with this custom editor script.

## Features

- **Bone Visibility**: Instantly view all bones linked to the `SkinnedMeshRenderer`.
- **Modify Bones**: Directly reassign and modify bone assignments within the Unity Inspector.

## Usage

- Select any GameObject with a `SkinnedMeshRenderer` component.
- The inspector will now display the list of associated bones at the bottom, allowing you to view and modify them directly.

## Notes

While the script allows viewing and modification of bone assignments, please remember that any changes will be effective only if the bones are correctly set up with the mesh in terms of weights and bindings. Ensure you are familiar with your mesh's rigging before making modifications.
