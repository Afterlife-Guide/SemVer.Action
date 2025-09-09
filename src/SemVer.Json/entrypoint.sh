#!/bin/sh
set -e

# Get the UID and GID of the workspace directory (default to 1000 if not found)
USER_ID=$(stat -c %u /github/workspace 2>/dev/null || echo 1000)
GROUP_ID=$(stat -c %g /github/workspace 2>/dev/null || echo 1000)

# Only create the user if it does not already exist
if ! id appuser >/dev/null 2>&1; then
    echo "Creating user with UID: $USER_ID and GID: $GROUP_ID"
    addgroup -g $GROUP_ID appgroup || true
    adduser -D -u $USER_ID -G appgroup appuser || true
fi

export HOME=/home/appuser

echo "[entrypoint.sh] Entrypoint script is running as $(whoami) (UID: $(id -u), GID: $(id -g))"

# Run the passed command as appuser
exec gosu appuser "$@"
